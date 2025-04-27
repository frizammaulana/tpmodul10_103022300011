using Microsoft.AspNetCore.Mvc;
using tpmodul10_103022300011;

namespace tpmodul10_103022300011.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> ListMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Frizam Dafa Maulana", "103022300011"),
            new Mahasiswa("Naufal Muhammad Dzulfikar", "103022300021"),
            new Mahasiswa("Bagas Pratama", "103022300035"),
            new Mahasiswa("Riziq Rizwan", "103022300119"),
            new Mahasiswa("Raffa Rizky Febryan", "103022330138")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return ListMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return ListMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            ListMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ListMahasiswa.RemoveAt(id);
        }
    }
}
