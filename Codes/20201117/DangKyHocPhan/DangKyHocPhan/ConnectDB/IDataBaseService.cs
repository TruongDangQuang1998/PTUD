using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.ConnectDB
{
    public interface IDataBaseService
    {
        void CreateIfNotExistsDB();
        Context GetContext();
    }
}
