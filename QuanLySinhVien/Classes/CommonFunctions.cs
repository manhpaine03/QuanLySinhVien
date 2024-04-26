using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLySinhVien.Classes
{
	internal class CommonFunctions
	{
		public void FillComboBox(ComboBox comboName, DataTable dt, string displayMember, string valueMember)
		{
			comboName.DataSource = dt;
			comboName.DisplayMember = displayMember;
			comboName.ValueMember = valueMember;
		}
	}
}
