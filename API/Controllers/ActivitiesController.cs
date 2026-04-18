using System;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers;

public class ActivitiesController(AppDbContex contex) : BaseApiController
{
     
     
     [HttpGet]
      public async Task<ActionResult<List<Activity>>> GetActivities()
    {
        
        return await contex.Activities.ToListAsync();
                      

    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Activity>> GetActivityDetail(string id)
    {
         
        var activity = await contex.Activities.FindAsync(id);

        if (activity == null) return NotFound();

        return activity;

    }



}
