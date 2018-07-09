using BankReconApi.Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace BankReconApi.Controllers
{
    public class FilesController : ApiController
    {
       
        [Route("upload")]
        [ResponseType(typeof(DataTable))]
        [HttpPost]
        public async Task<DataTable> UploadFile(HttpRequestMessage request)
        {
            DataTable data = new DataTable();
            if (!request.Content.IsMimeMultipartContent())
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);

            data = await Request.Content.ParseMultipartAsync();
            

            return data;
        }



    }
   

}
