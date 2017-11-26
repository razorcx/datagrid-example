using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TSDUI = Tekla.Structures.Dialog.UIControls;
using System.Windows.Forms;
using Tekla.Structures;
using Tekla.Structures.Model;

namespace DataGridExample
{
	public partial class QuickViewer : Form
	{
		private readonly Model _model = new Model();
		private dynamic _data;

		public QuickViewer()
		{
			InitializeComponent();

			this.cmbBoxMember.DataSource = GetBeamNames();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			var beams = GetBeams();
			GetData(beams);
			this.txtBoxSearch.Text = string.Empty;
			this.dataGridMembers.DataSource = _data;
		}

		private void cmbBoxMember_SelectedIndexChanged(object sender, EventArgs e)
		{
			var beams = GetBeams();
			GetData(beams);
			this.txtBoxSearch.Text = string.Empty;
			this.dataGridMembers.DataSource = _data;
		}

		private List<string> GetBeamNames()
		{
			return 
				GetBeams()
				.Select(b => b.Name)
				.Distinct()
				.OrderBy(b => b)
				.ToList();
		}

		private void GetData(List<Beam> beams)
		{
			_data = beams
				.Where(b => b.Name == this.cmbBoxMember.Text)
				.Select(b =>
				{
					var phase = -1;
					b.GetReportProperty("PHASE", ref phase);

					var assemblyPos = string.Empty;
					b.GetReportProperty("ASSEMBLY_POS", ref assemblyPos);

					return new
					{
						Id = b.Identifier.ID,
						Phase = phase,
						Assembly_Mark = assemblyPos,
						Name = b.Name,
						Profile = b.Profile.ProfileString,
						Class = b.Class,
						Finish = b.Finish,
						Material = b.Material.MaterialString,
					};
				})
				.OrderBy(b => b.Phase)
				.ThenBy(b => b.Name)
				.ThenBy(b => b.Profile)
				.ToList();
		}

		private List<Beam> GetBeams()
		{
			ModelObjectEnumerator.AutoFetch = true;
			var moe = _model.GetModelObjectSelector().GetAllObjectsWithType(ModelObject.ModelObjectEnum.BEAM);
			return 
				moe
				.ToList()
				.OfType<Beam>()
				.ToList();
		}

		private void SelectModelObjectsInUi(List<int> ids)
		{
			var modelObjects = new ArrayList();

			ids.ForEach(id => 
			{
				var modelObject = _model.SelectModelObject(new Identifier(id));
				if (modelObject == null) return;
				modelObjects.Add(modelObject);
			});

			var selector = new Tekla.Structures.Model.UI.ModelObjectSelector();
			selector.Select(modelObjects);
		}

		private void txtBoxSearch_TextChanged(object sender, EventArgs e)
		{
			var searchText = ((TextBox) sender).Text;
			if (string.IsNullOrEmpty(searchText)) return;

			var beams = GetBeams()
				.Where(b => b.Name == this.cmbBoxMember.Text)
				.Where(b =>
				{
					var assemblyPos = string.Empty;
					b.GetReportProperty("ASSEMBLY_POS", ref assemblyPos);

					return assemblyPos.Contains(searchText);
				})
				.ToList();

			GetData(beams);
			this.dataGridMembers.DataSource = _data;
		}

		private void dataGridMembers_SelectionChanged(object sender, EventArgs e)
		{
			var selectedRows = GetSelectedRows(sender);
			var ids = GetIds(selectedRows);
			SelectModelObjectsInUi(ids);
		}

		private List<DataGridViewRow> GetSelectedRows(object sender)
		{
			var dataGrid = sender as TSDUI.DataGrid;
			return dataGrid?.SelectedRows.OfType<DataGridViewRow>().ToList();
		}

		private List<int> GetIds(List<DataGridViewRow> rows)
		{
			return rows
				.Select(r => (int)((dynamic)r.DataBoundItem).Id)
				.ToList();
		}
	}
}
