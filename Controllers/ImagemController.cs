using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
namespace lista_de_computadores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagemController : ControllerBase
    {
        
        public static IWebHostEnvironment _environment;
        public ImagemController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        [HttpGet]
        public string Get()
        {
            string texto = " Web API - ImagemController em execução : " + DateTime.Now.ToLongTimeString();
            texto += $"\n Ambiente :  {_environment.EnvironmentName}";
            return texto;
        }      

       [HttpPost("upload")]
       public async Task<string> EnviaArquivo([FromForm] IFormFile arquivo)
       {

            string pasta = "imagens";
            string caminho_WebRoot = _environment.WebRootPath;
            string caminhoImagens = Path.Combine(caminho_WebRoot, pasta);
          if (arquivo.Length > 0)
           {
                try
                {
                    string teste = _environment.WebRootPath+"\\images\\";
                    /*
                    if (!Directory.Exists(teste))
                    {
                        
                        Directory.CreateDirectory(teste);
                         
                }
               */
                using (FileStream filestream = System.IO.File.Create(caminhoImagens + arquivo.FileName))
                {
                        await arquivo.CopyToAsync(filestream);
                        filestream.Flush();
                        return "\\images\\" + arquivo.FileName;
                    }
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
            else
            {
                return "Ocorreu uma falha no envio do arquivo...";
            }
        }
    }
}

