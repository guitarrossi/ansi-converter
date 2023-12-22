using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANSIConverter.Service
{
    public interface IEncodingService
    {
        string ChangeEncodeToANSI(string path, ProgressBar progressBar);
    }
}
