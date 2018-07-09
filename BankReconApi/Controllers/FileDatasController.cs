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
    public class FileDatasController : ApiController
    {
        private BankReconApiContext db = new BankReconApiContext();

        // GET: api/FileDatas
        public IQueryable<FileData> GetFileDatas()
        {
            return db.FileDatas;
        }

        // GET: api/FileDatas/5
        [ResponseType(typeof(FileData))]
        public async Task<IHttpActionResult> GetFileData(int id)
        {
            FileData fileData = await db.FileDatas.FindAsync(id);
            if (fileData == null)
            {
                return NotFound();
            }

            return Ok(fileData);
        }

        // PUT: api/FileDatas/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutFileData(int id, FileData fileData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fileData.ID)
            {
                return BadRequest();
            }

            db.Entry(fileData).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FileDataExists(id))
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

        // POST: api/FileDatas
        [ResponseType(typeof(FileData))]
        public async Task<IHttpActionResult> PostFileData(FileData fileData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FileDatas.Add(fileData);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = fileData.ID }, fileData);
        }

        // DELETE: api/FileDatas/5
        [ResponseType(typeof(FileData))]
        public async Task<IHttpActionResult> DeleteFileData(int id)
        {
            FileData fileData = await db.FileDatas.FindAsync(id);
            if (fileData == null)
            {
                return NotFound();
            }

            db.FileDatas.Remove(fileData);
            await db.SaveChangesAsync();

            return Ok(fileData);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FileDataExists(int id)
        {
            return db.FileDatas.Count(e => e.ID == id) > 0;
        }
    }
}