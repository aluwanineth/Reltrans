using Dex.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Application.Features.Customer.Queries.GetCustomerByEmail;
using RelTransCustomer.Application.Features.Customer.Queries.GetCustomerOrders;
using RelTransCustomer.Application.Features.DesignGA.Commands.UpdateDesignGA;
using RelTransCustomer.Application.Features.DesignGA.Queries.GetDesignGAByAccNo;
using RelTransCustomer.Application.Features.DesignGA.Queries.GetDesignGAById;
using RelTransCustomer.Controllers;

namespace RelTransCustomer.WebApi.Controllers.V1
{

    [ApiVersion("1.0")]
    public class DesignGAController : BaseApiController
    {
        private readonly string _uploadDirectory;
        private readonly IDesignGARepositoryAsync _designGARepositoryAsync;

        public DesignGAController(IConfiguration configuration, IDesignGARepositoryAsync designGARepositoryAsync)
        {
            _uploadDirectory = configuration["UploadDirectory"];
            _designGARepositoryAsync = designGARepositoryAsync;

        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("getDesignGAByAccNo")]
        public async Task<IActionResult> GetDesignGAByAccNo([FromQuery] string accNo)
        {
            return Ok(await Mediator.Send(new GetDesignGAByAccNoQuery { AccNo = accNo }));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("getDesignGA")]
        public async Task<IActionResult> GetDesignGA([FromQuery] int id)
        {
            return Ok(await Mediator.Send(new GetDesignGAByIdQuery { Id = id }));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPut("updatetDesignGA")]
        public async Task<IActionResult> UpdateDesignGA([FromBody] DesignGa designGa)
        {
            return Ok(await Mediator.Send(new UpdateDesignGACommand { DesignGa = designGa }));
        }

        [HttpGet]
        [Route("downloadFile/{id}")]
        public async Task<IActionResult> DownloadFile(int id)
        {
            // get a path
            var result = await _designGARepositoryAsync.Get(id);
            var filePath = Path.Combine(result.FileLocation,result.DocName);   
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }

            var fileBytes = await System.IO.File.ReadAllBytesAsync(filePath);
            var contentType = GetContentType(filePath);
            return File(fileBytes, contentType, Path.GetFileName(filePath));
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("No file uploaded.");
            }

            // Validate file extension (optional)
            if (!IsValidFileType(file.FileName))
            {
                return BadRequest("Invalid file type.");
            }

            // Validate file size (optional)
            if (file.Length > 10 * 1024 * 1024) // 10MB limit
            {
                return BadRequest("File size exceeds limit.");
            }

            // Generate a unique file name
            var fileName = GenerateUniqueFileName(file.FileName);

            // Create the upload directory if it doesn't exist
            if (!Directory.Exists(_uploadDirectory))
            {
                Directory.CreateDirectory(_uploadDirectory);
            }

            // Save the file
            var filePath = Path.Combine(_uploadDirectory, fileName);
            await using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return Ok("File uploaded successfully."); // Or return more detailed information
        }

        private string GetContentType(string filePath)
        {
            string contentType;
            new FileExtensionContentTypeProvider().TryGetContentType(filePath, out contentType);
            return contentType ?? "application/octet-stream";
        }

        private bool IsValidFileType(string fileName)
        {
            // Add your logic to check allowed extensions (e.g., using MIME types)
            return fileName.EndsWith(".pdf");
        }

        private string GenerateUniqueFileName(string fileName)
        {
            // Use a GUID or other method to ensure uniqueness
            return Guid.NewGuid().ToString() + Path.GetExtension(fileName);
        }
    }
}
