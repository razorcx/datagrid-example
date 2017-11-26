using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures.Model;

namespace DataGridExample
{
	public partial class DataGridExample : Form
	{
		public DataGridExample()
		{
			InitializeComponent();

			var beamNames = GetBeams()
				.Select(b => b.Name)
				.Distinct()
				.OrderBy(b => b)
				.ToList();

			this.cmbBoxMember.DataSource = beamNames;
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			this.dataGridMembers.DataSource = GetData();
		}

		private void cmbBoxMember_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.dataGridMembers.DataSource = GetData();
		}

		private dynamic GetData()
		{
			var beams = GetBeams();

			var beamsReport = beams
				.Where(b => b.Name == this.cmbBoxMember.Text)
				.Select(b => new
				{
					Name = b.Name,
					Profile = b.Profile.ProfileString,
					Class = b.Class,
					Finish = b.Finish,
					Material = b.Material.MaterialString
				})
				.OrderBy(b => b.Name)
				.ThenBy(b => b.Profile)
				.ToList();

			return beamsReport;
		}

		private List<Beam> GetBeams()
		{
			ModelObjectEnumerator.AutoFetch = true;
			var moe = new Model().GetModelObjectSelector().GetAllObjectsWithType(ModelObject.ModelObjectEnum.BEAM);

			var modelObjects = moe.ToList();

			var beams = modelObjects.OfType<Beam>().ToList();

			return beams;
		}
	}
}
