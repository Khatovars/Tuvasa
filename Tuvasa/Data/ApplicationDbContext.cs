using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tuvasa.Areas.BoardGameGames.Models;

namespace Tuvasa.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Tuvasa.Areas.BoardGameGames.Models.Player> Player { get; set; }
    }

    public class AppUser : IdentityUser
    {
        public string Nickname { get; set; }
    }
}
