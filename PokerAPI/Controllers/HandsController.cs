﻿using Microsoft.AspNetCore.Mvc;
using PokerAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace PokerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HandsController : ControllerBase
    {
        private readonly PokerAPIContext _context;
        public HandsController(PokerAPIContext context)
        {
            _context = context;
        }

        // GET: api/Hands
        [HttpGet]
        public IEnumerable<Hand> Get()
        {
            return _context.Hands;
        }
        // GET: api/Hands/5
        [HttpGet("{Id}")]
        public Hand Get(int Id)
        {
            return _context.Hands.Find(Id);
        }
        
        // POST: api/Hands
        [HttpPost]
        public void Post([FromBody] List<Hand> hands)
        {
            _context.Add(hands);
            _context.SaveChanges();
        }
    }
}
