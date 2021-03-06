﻿using Microsoft.EntityFrameworkCore;

namespace PokerAPI.Models
{
    public class PokerAPIContext : DbContext
    {
        public PokerAPIContext (DbContextOptions<PokerAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }

        public DbSet<Hand> Hands { get; set; }
        public DbSet<Card> Cards { get; set; }
    }
}
