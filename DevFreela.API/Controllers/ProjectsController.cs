﻿using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers;

[Route("api/projects")]
public class ProjectsController : ControllerBase
{
    // api/projects?query=net core
    [HttpGet]
    public IActionResult Get(string query)
    {
        // Buscar todos ou filtrar
        return Ok();
    }



    // api/projects/3
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        // return NotFound();
        // Buscar o projeto
        return Ok();
    }



    [HttpPost]
    public IActionResult Post([FromBody] CreateProjectModel createProject)
    {
        if (createProject.Title.Length > 50)
        {
            return BadRequest();
        }
        // Cadastrar o projeto
        return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);
    }



    // api/projects/2
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
    {
        if (updateProject.Description.Length > 200)
        {
            return BadRequest();
        }
        // Atualiza o objeto
        return NoContent();
    }



    // api/projects/3 DELETE
    [HttpDelete("{id}")]
    public IActionResult Delete(int id, [FromBody] UpdateProjectModel updateProject)
    {
        if (updateProject.Description.Length > 200)
        {
            // Busca, se não existir, .. NotFound
            return BadRequest();
        }
        // Remove o objeto
        return NoContent();
    }



    // api/projects/1/comments
    [HttpPost("{id}/comments")]
    public IActionResult PostComment([FromBody] CreateCommentModel createComment)
    {
        return CreatedAtAction(nameof(GetById), new { id = 1 }, createComment);
    }



    // api/projects/1/start
    [HttpPut("{id}/start")]
    public IActionResult Start(int id)
    {
        return NoContent();
    }



    // api/projects/1/finisth
    [HttpPut("{id}/finisth")]
    public IActionResult Finish(int id)
    {
        return NoContent();
    }
}
