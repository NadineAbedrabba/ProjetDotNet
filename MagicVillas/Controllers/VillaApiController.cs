using AutoMapper;
using MagicVilla_VillaAPI.Models;
using MagicVillas.Data;
using MagicVillas.Logging;
using MagicVillas.Models;
using MagicVillas.Models.Dto;
using MagicVillas.Repository.IRepository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Runtime.Intrinsics.Arm;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace MagicVillas.Controllers
{
    [Route("api/getVillas")]
    [ApiController]

    public class VillaApiController : ControllerBase
    {
        //private readonly ILogging _logger;

        /* public VillaApiController(ILogging logger)
         {
             _logger = logger;
         }*/
        protected APIResponse _response;
        private readonly IVillaRepository _dbVilla;
        private readonly IMapper _mapper;
        public VillaApiController(IVillaRepository dbVilla , IMapper mapper) {
            _dbVilla = dbVilla;
            _mapper = mapper;
            this._response = new();
        } 
        [ HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<APIResponse>> GetVillas()
        {
            //_logger.Log("Afficher toutes les villas","");
            IEnumerable<Villa> villaList = await _dbVilla.GetAllAsync();
            _response.Result= _mapper.Map<List<VillaDTO>>(villaList);
            _response.StatusCode=HttpStatusCode.OK;
            return Ok(_response);

        }
        [HttpGet("{id:int}", Name ="GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async  Task<ActionResult<VillaDTO>> GetVilla(int id)
        {
            if (id == 0)
            {
                //_logger.Log("une erreur s'est produite lors getting villa " + id,"error");
                return BadRequest();
            }
            var villa = await _dbVilla.GetAsync(u => u.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            _response.Result = _mapper.Map<VillaDTO>(villa);
            _response.StatusCode = HttpStatusCode.OK;
            return Ok(_response);
        }
        [HttpPost ]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<VillaDTO>> CreateVilla([FromBody] VillaCreateDTO createDTO)
        {
            /*if (!ModelState.IsValid)
            {
                return(BadRequest(ModelState));   
            }
            */
            if (createDTO == null)
            {
                return BadRequest(createDTO);
            }
            if (!(await _dbVilla.GetAsync( u => u.Name.ToLower() == createDTO.Name.ToLower()) ==null))
            {
                ModelState.AddModelError("VerifExistanceError", "villa already exists");
                return BadRequest(ModelState);

            }
            
           
           
            /*villaDTO.Id = VillaStore.villalist.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
            VillaStore.villalist.Add(villaDTO);*/
            Villa villa = _mapper.Map<Villa>(createDTO);
            /*Villa model = new()
            {
             Name = createDTO.Name,
             Description = createDTO.Description,
             Sqft = createDTO.Sqft   ,
             Rate  = createDTO.Rate,
             ImageUrl = createDTO.ImageUrl,
             Price = createDTO.Price,
             
            };*/
            await _dbVilla.CreateAsync(villa);
            await _dbVilla.SaveAsync();
            _response.Result = _mapper.Map<VillaDTO>(villa);
            _response.StatusCode = HttpStatusCode.Created;
            return CreatedAtRoute("GetVilla",new {id = villa.Id},_response);
        }
        [HttpDelete("{id:int}", Name ="DeleteVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> DeleteVilla(int id)
        {
            if (id == 0)
            {
                return (BadRequest());
            }
            var villa= await _dbVilla.GetAsync(u => u.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            //VillaStore.villalist.Remove(villa);
            _dbVilla.RemoveAsync(villa);
            _response.StatusCode = HttpStatusCode.NoContent;
            _response.IsSuccess = true;
            return Ok(_response);
        }
        [HttpPut("{id:int}" , Name ="UpdateVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
       /* public async Task<IActionResult> UpdateVilla(int id, [FromBody] VillaUpdateDTO updateDTO)
        {
            if (updateDTO == null || id != updateDTO.Id)
            {
                return BadRequest();
            }
            /* var villa = await _dbVilla.GetAsync(v => v.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            /*villa.Name=villaDTO.Name;
            villa.Description=villaDTO.Description;
            villa.Price=villaDTO.Price;*/
           /* Villa model = new()
             {
                 Id = villaDTO.Id,
                 Name = villaDTO.Name,
                 Description = villaDTO.Description,
                 Rate = villaDTO.Rate,
                 Sqft = villaDTO.Sqft,   
                 ImageUrl = villaDTO.ImageUrl,
                 Price = villaDTO.Price,

             };*/
            /*villa.Name = villaDTO.Name;
            villa.Description = villaDTO.Description;
            villa.Rate = villaDTO.Rate;
            villa.Sqft = villaDTO.Sqft;
            villa.ImageUrl = villaDTO.ImageUrl;
            villa.Price = villaDTO.Price;

            // Save changes to the database
            try
            {
                await _dbVilla.SaveAsync();
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }*/

           /* Villa model = _mapper.Map<Villa>(updateDTO);
            await _dbVilla.UpdateAsync(model);




            return (NoContent());
        }*/
        public async Task<IActionResult> UpdateVilla(int id, [FromBody] VillaUpdateDTO updateDTO)
        {
            if (updateDTO == null || id != updateDTO.Id)
            {
                return BadRequest(new {message ="data invalides"});
            }

            // Check if the villa exists
            var villa = await _dbVilla.GetAsync(v => v.Id == id);
            if (villa == null)
            {
                return NotFound();
            }

            // Map the updateDTO to a Villa model
            Villa model = _mapper.Map<Villa>(updateDTO);

            // Update the villa in the database
            try
            {
                await _dbVilla.UpdateAsync(model);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

            return NoContent();
        }

        [HttpPatch("{id:int}",Name ="UpdatePartialVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialVilla (int id,[FromBody]JsonPatchDocument<VillaUpdateDTO> patchDTO)
        {
            if (patchDTO == null || id == 0)
            {
              return BadRequest();
            }
            var villa = await _dbVilla.GetAsync(u => u.Id == id, tracked:false);
            VillaUpdateDTO villaDTO = _mapper.Map<VillaUpdateDTO>(villa);   
            if (villa == null)
            {
                return BadRequest();
            }
/*
            VillaDTO villaDTO = new()
            {
                Id = villa.Id,
                Name = villa.Name,
                Description = villa.Description,
                Sqft = villa.Sqft,
                Rate = villa.Rate,
                ImageUrl = villa.ImageUrl,
                Price = villa.Price,
            };*/
           
            patchDTO.ApplyTo(villaDTO , ModelState);
            Villa model = _mapper.Map<Villa>(villaDTO);
            await _dbVilla.UpdateAsync(model);
           
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            /* villa.Name = villaDTO.Name;
             villa.Description = villaDTO.Description;
             villa.Sqft = villaDTO.Sqft;
             villa.Rate = villaDTO.Rate;
             villa.ImageUrl = villaDTO.ImageUrl;
             villa.Price = villaDTO.Price;*/
            await _dbVilla.SaveAsync();


            return NoContent();
        } 




    }
}
    

