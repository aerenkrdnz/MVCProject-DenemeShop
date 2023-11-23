using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeShop.Data.Enums
{
	public enum UserTypeEnum
	{
		User = 1, // bool ile karışmasın diye sql tarafında 1 verdik ki diğer gelenler 2,3 diye gidebilsin.
		Admin
	}
}
