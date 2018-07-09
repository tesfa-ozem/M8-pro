using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using BankReconApi.Models;

namespace BankReconApi.Controllers
{
    public class FileTypesController : ApiController
    {
        private BankReconApiContext db = new BankReconApiContext();

        // GET: api/FileTypes
        public IQueryable<FileType> GetFileTypes()
        {
            return db.FileTypes;
        }

        // GET: api/FileTypes/5
        [ResponseType(typeof(FileType))]
        public async Task<IHttpActionResult> GetFileType(int id)
        {
            FileType fileType = await db.FileTypes.FindAsync(id);
            if (fileType == null)
            {
                return NotFound();
            }

            return Ok(fileType);
        }

        // PUT: api/FileTypes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutFileType(int id, FileType fileType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fileType.FileId)
            {
                return BadRequest();
            }

            db.Entry(fileType).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FileTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/FileTypes
        [ResponseType(typeof(FileType))]
        public async Task<IHttpActionResult> PostFileType(FileType fileType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FileTypes.Add(fileType);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = fileType.FileId }, fileType);
        }

        // DELETE: api/FileTypes/5
        [ResponseType(typeof(FileType))]
        public async Task<IHttpActionResult> DeleteFileType(int id)
        {
            FileType fileType = await db.FileTypes.FindAsync(id);
            if (fileType == null)
            {
                return NotFound();
            }

            db.FileTypes.Remove(fileType);
            await db.SaveChangesAsync();

            return Ok(fileType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FileTypeExists(int id)
        {
            return db.FileTypes.Count(e => e.FileId == id) > 0;
        }
    }
}