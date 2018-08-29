using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OteoModel.Classes;
using System.Web.Http.Cors;

namespace OteoWebService.Controllers
{
    public class ValuesController : ApiController
    {


        /***********************************Buscar Lista********************************************/


        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("BuscarEmpresas")]
        [HttpGet()]
        public IHttpActionResult buscarEmpresas()
        {

            var ema001001 = new Emtba001001();

            var lEma001001 = ema001001.buscarLista();

            return Ok(lEma001001);

        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("BuscarFuncoes")]
        [HttpGet()]
        public IHttpActionResult buscarFuncoes()
        {

            var fua001001 = new Futba001001();

            var lFua001001 = fua001001.buscarLista();

            return Ok(lFua001001);

        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("BuscarTiposUsuario")]
        [HttpGet()]
        public IHttpActionResult buscarTiposUsuario()
        {

            var tua001001 = new Tutba001001();

            var lTua001001 = tua001001.buscarLista();

            return Ok(lTua001001);

        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("BuscarUsuarios")]
        [HttpGet()]
        public IHttpActionResult buscarUsuarios()
        {

            var usa001001 = new Ustba001001();

            var lUsa001001 = usa001001.buscarLista();

            return Ok(lUsa001001);

        }


        /***********************************Buscar Objeto********************************************/

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("BuscarEmpresa")]
        [HttpGet()]
        public IHttpActionResult buscarEmpresa(int ema001001id)
        {

            var ema001001 = new Emtba001001();

            ema001001 = ema001001.buscar(ema001001id);

            return Ok(ema001001);

        }


        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("BuscarFuncao")]
        [HttpGet()]
        public IHttpActionResult buscarFuncao(int fua001001id)
        {

            var fua001001 = new Futba001001();

            fua001001 = fua001001.buscar(fua001001id);

            return Ok(fua001001);

        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("BuscarTipoUsuario")]
        [HttpGet()]
        public IHttpActionResult buscarTipoUsuario(int tua001001id)
        {

            var tua001001 = new Tutba001001();

            tua001001 = tua001001.buscar(tua001001id);

            return Ok(tua001001);

        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("BuscarUsuario")]
        [HttpGet()]
        public IHttpActionResult buscarUsuario(int usa001001id)
        {

            var usa001001 = new Ustba001001();

            usa001001 = usa001001.buscar(usa001001id);

            return Ok(usa001001);

        }


        /***********************************Inserir********************************************/

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("InserirEmpresa")]
        [HttpPost()]
        public IHttpActionResult inserirEmpresa([FromBody]Emtba001001 pEma001001)
        {

            var ema001001 = new Emtba001001();

            ema001001.inserir(pEma001001);

            return Ok("ok");
        }


        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("InserirFuncao")]
        [HttpPost()]
        public IHttpActionResult inserirFuncao([FromBody]Futba001001 pfua001001)
        {

            var fua001001 = new Futba001001();

            fua001001.inserir(pfua001001);

            return Ok("ok");
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("InserirTipoUsuario")]
        [HttpPost()]
        public IHttpActionResult InserirTipoUsuario([FromBody]Tutba001001 pTua001001)
        { 

            var tua001001 = new Tutba001001();

            tua001001.inserir(pTua001001);

            return Ok("ok");
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("InserirUsuario")]
        [HttpPost()]
        public IHttpActionResult inserirUsuario([FromBody]Ustba001001 pUsa001001)
        {

            var usa001001 = new Ustba001001();

            usa001001.inserir(pUsa001001);

            return Ok("ok");
        }

        /***********************************Alterar********************************************/

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("AlterarEmpresa")]
        [HttpPut()]
        public IHttpActionResult alterarEmpresa([FromBody]Emtba001001 pEma001001)
        {
            var ema001001 = new Emtba001001();

            ema001001.alterar(pEma001001);

            return Ok("ok");
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("AlterarFuncao")]
        [HttpPut()]
        public IHttpActionResult alterarFuncao([FromBody]Futba001001 pFua001001)
        {
            var fua001001 = new Futba001001();

            fua001001.alterar(pFua001001);

            return Ok("ok");
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("AlterarTipoUsuario")]
        [HttpPut()]
        public IHttpActionResult alterarTipoUsuario([FromBody]Tutba001001 pTua001001)
        {
            var tua001001 = new Tutba001001();

            tua001001.alterar(pTua001001);

            return Ok("ok");
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("AlterarUsuario")]
        [HttpPut()]
        public IHttpActionResult alterarUsuario([FromBody]Ustba001001 pUsa001001)
        {
            var usa001001 = new Ustba001001();

            usa001001.alterar(pUsa001001);

            return Ok("ok");
        }

        /***********************************Deletar********************************************/
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("DeletarEmpresa")]
        [HttpDelete()]
        public IHttpActionResult deletarEmpresa(int idEma001001)
        {

            var ema001001 = new Emtba001001();

            ema001001.deletar(idEma001001);

            return Ok("ok");
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("DeletarFuncao")]
        [HttpDelete()]
        public IHttpActionResult deletarFuncao(int idFua001001)
        {

            var fua001001 = new Futba001001();

            fua001001.deletar(idFua001001);

            return Ok("ok");
        }


        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("DeletarTipoUsuario")]
        [HttpDelete()]
        public IHttpActionResult deletarTipoUsuario(int idTua001001)
        {

            var tua001001 = new Tutba001001();

            tua001001.deletar(idTua001001);

            return Ok("ok");
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("DeletarUsuario")]
        [HttpDelete()]
        public IHttpActionResult deletarUsuario(int idUsa001001)
        {

            var usa001001 = new Ustba001001();

            usa001001.deletar(idUsa001001);

            return Ok("ok");
        }


















    }
}
