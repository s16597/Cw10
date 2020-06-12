﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw10.DAL;
using Cw10.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Cw10.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private IConfiguration Configuration { get; set; }
        private IDbService _dbService;

        public StudentsController(IDbService dbService, IConfiguration configuration)
        {
            _dbService = dbService;
            Configuration = configuration;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            //return Ok();
            return Ok(_dbService.GetStudents());
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(string id)
        {
            return Ok(_dbService.GetStudent(id));
        }

        [HttpPost] // add
        public IActionResult CreateStudent(Student student)
        {
            if (_dbService.AddStudent(student))
                return Ok(student);
            else
                return BadRequest("Student już istnieje " + student.IndexNumber);
        }

        [HttpPut("{id}")] // update
        public IActionResult UpdateStudent(string id)
        {

            if (_dbService.UpdateStudent(id))
                return Ok("Aktualizacja zakończona: " + id);
            else
                return NotFound("Nie znaleziono studenta o indeksie: " + id);
        }

        [HttpDelete("{id}")] // delete
        public IActionResult DeleteStudent(string id)
        {
            var student = _dbService.GetStudents().Where(s => s.IndexNumber == id).FirstOrDefault();
            if (student != null)
            {
                _dbService.DeleteStudent(student);
                return Ok("Usuwanie zakonczone: " + id);
            }
            else
            {
                return NotFound("Nie znaleziono studenta o indeksie: " + id);
            }
        }

    }
}
