using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using week4.Dtos;
using week4.Entitites;
using week4.Interfaces;
using week4.Services;

namespace week4.Controllers
{
    [Route("api/[controller]")]
[ApiController]
    public class EvcilHayvanApiController
    {
        private readonly IEvcilHayvanService _evcilHayvanService;
        private readonly IKullaniciService _kullaniciService;
        public EvcilHayvanApiController(IEvcilHayvanService evcilHayvanService, IKullaniciService kullaniciService)
        {
            _evcilHayvanService = evcilHayvanService;
            _kullaniciService = kullaniciService;
        }

        [HttpPost("addKullanici")]
        public async Task<IActionResult> YeniKullaniciOlustur(Kullanici kullanici)
        {
            _kullaniciService.AddKullanici(kullanici);
            return null;
        }

        [HttpGet("kullanicilar/{kullaniciId}")]
        public IActionResult GetKullaniciById(int kullaniciId)
        {
            var kullanici = _kullaniciService.GetKullaniciById(kullaniciId);

            return null;
        }
    }
}
