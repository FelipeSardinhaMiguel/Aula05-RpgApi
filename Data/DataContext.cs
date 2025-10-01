using RpgAPI.Models.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RpgAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using RpgAPI.Utils;

namespace RpgAPI.Data
{
    public class DataContext : DbContext
    {
        //ctor
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        //prop
        public DbSet<Personagem> TB_PERSONAGENS { get; set; }
        public DbSet<Arma> TB_ARMAS { get; set; }
        public DbSet<Usuario> TB_USUARIOS { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personagem>().ToTable("TB_PERSONAGENS");
            modelBuilder.Entity<Arma>().ToTable("TB_ARMAS");
            modelBuilder.Entity<Arma>().ToTable("TB_USUARIOS");  

            //Relacionamentos One to Many (Um para muitos)
            modelBuilder.Entity<Usuario>()
                    .HasMany(e => e.Personagens)
                    .WithOne(e => e.Usuario)
                    .HasForeignKey(e => e.UsuarioId)
                    .IsRequired(false);   

            modelBuilder.Entity<Personagem>().HasData
            (                
                new Personagem() { Id = 1, Nome = "Frodo", PontosVida = 100, Forca = 17, Defesa = 23, Inteligencia = 33, Classe = ClasseEnum.Cavaleiro, UsuarioId = 1 },
                new Personagem() { Id = 2, Nome = "Sam", PontosVida = 100, Forca = 15, Defesa = 25, Inteligencia = 30, Classe = ClasseEnum.Cavaleiro, UsuarioId = 1 },
                new Personagem() { Id = 3, Nome = "Galadriel", PontosVida = 100, Forca = 18, Defesa = 21, Inteligencia = 35, Classe = ClasseEnum.Clerigo, UsuarioId = 1 },
                new Personagem() { Id = 4, Nome = "Gandalf", PontosVida = 100, Forca = 18, Defesa = 18, Inteligencia = 37, Classe = ClasseEnum.Mago, UsuarioId = 1 },
                new Personagem() { Id = 5, Nome = "Hobbit", PontosVida = 100, Forca = 20, Defesa = 17, Inteligencia = 31, Classe = ClasseEnum.Cavaleiro, UsuarioId = 1 },
                new Personagem() { Id = 6, Nome = "Celeborn", PontosVida = 100, Forca = 21, Defesa = 13, Inteligencia = 34, Classe = ClasseEnum.Clerigo, UsuarioId = 1 },
                new Personagem() { Id = 7, Nome = "Radagast", PontosVida = 100, Forca = 25, Defesa = 11, Inteligencia = 35, Classe = ClasseEnum.Mago, UsuarioId = 1 }
            );

             modelBuilder.Entity<Arma>().HasData
            (
                new Arma() { Id = 1, Nome = "Treisoitão", Dano = 38, Tipo = "Medio Alcance"},
                new Arma() { Id = 2, Nome = "M4", Dano = 30, Tipo = "Longo Alcance"},
                new Arma() { Id = 3, Nome = "AK47", Dano = 40, Tipo = "Longo Alcance"},
                new Arma() { Id = 4, Nome = "Coquetel Molotov", Dano = 5*7, Tipo = "Arremessável"},
                new Arma() { Id = 5, Nome = "Lança Chamas", Dano = 10*13, Tipo = "Longo alcance"},
                new Arma() { Id = 6, Nome = "Espada de Grama", Dano = 70, Tipo = "Corpo a corpo"},
                new Arma() { Id = 7, Nome = "Ominitrix", Dano = 100, Tipo = "Corpo a Corpo"}
            );

            //Início da criação do usuário padrão.
            Usuario user = new Usuario();
            Criptografia.CriarPasswordHash("123456", out byte[] hash, out byte[] salt);
            user.Id = 1;
            user.Username = "UsuarioAdmin";
            user.PasswordString = string.Empty;
            user.PasswordHash = hash;
            user.PasswordSalt = salt;
            user.Perfil = "Admin";
            user.Email = "seuEmail@gmail.com";
            user.Latitude = -23.5200241;
            user.Longitude = -46.596498;

            modelBuilder.Entity<Usuario>().HasData(user);
            //Fim da criação do usuário padrão.

            modelBuilder.Entity<Usuario>().Property(u => u.Perfil).HasDefaultValue("Jogador");

        }*/


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personagem>().ToTable("TB_PERSONAGENS");
            modelBuilder.Entity<Arma>().ToTable("TB_ARMAS");
            modelBuilder.Entity<Arma>().ToTable("TB_USUARIOS");  

            //Relacionamentos One to Many (Um para muitos)
            modelBuilder.Entity<Usuario>()
                    .HasMany(e => e.Personagens)
                    .WithOne(e => e.Usuario)
                    .HasForeignKey(e => e.UsuarioId)
                    .IsRequired(false);   

            modelBuilder.Entity<Personagem>().HasData
            (                
                new Personagem() { Id = 1, Nome = "Frodo", PontosVida = 100, Forca = 17, Defesa = 23, Inteligencia = 33, Classe = ClasseEnum.Cavaleiro, UsuarioId = 1 },
                new Personagem() { Id = 2, Nome = "Sam", PontosVida = 100, Forca = 15, Defesa = 25, Inteligencia = 30, Classe = ClasseEnum.Cavaleiro, UsuarioId = 1 },
                new Personagem() { Id = 3, Nome = "Galadriel", PontosVida = 100, Forca = 18, Defesa = 21, Inteligencia = 35, Classe = ClasseEnum.Clerigo, UsuarioId = 1 },
                new Personagem() { Id = 4, Nome = "Gandalf", PontosVida = 100, Forca = 18, Defesa = 18, Inteligencia = 37, Classe = ClasseEnum.Mago, UsuarioId = 1 },
                new Personagem() { Id = 5, Nome = "Hobbit", PontosVida = 100, Forca = 20, Defesa = 17, Inteligencia = 31, Classe = ClasseEnum.Cavaleiro, UsuarioId = 1 },
                new Personagem() { Id = 6, Nome = "Celeborn", PontosVida = 100, Forca = 21, Defesa = 13, Inteligencia = 34, Classe = ClasseEnum.Clerigo, UsuarioId = 1 },
                new Personagem() { Id = 7, Nome = "Radagast", PontosVida = 100, Forca = 25, Defesa = 11, Inteligencia = 35, Classe = ClasseEnum.Mago, UsuarioId = 1 }
            );

             modelBuilder.Entity<Arma>().HasData
            (
                new Arma() { Id = 1, Nome = "Treisoitão", Dano = 38, Tipo = "Medio Alcance"},
                new Arma() { Id = 2, Nome = "M4", Dano = 30, Tipo = "Longo Alcance"},
                new Arma() { Id = 3, Nome = "AK47", Dano = 40, Tipo = "Longo Alcance"},
                new Arma() { Id = 4, Nome = "Coquetel Molotov", Dano = 5*7, Tipo = "Arremessável"},
                new Arma() { Id = 5, Nome = "Lança Chamas", Dano = 10*13, Tipo = "Longo alcance"},
                new Arma() { Id = 6, Nome = "Espada de Grama", Dano = 70, Tipo = "Corpo a corpo"},
                new Arma() { Id = 7, Nome = "Ominitrix", Dano = 100, Tipo = "Corpo a Corpo"}
            );

            //Início da criação do usuário padrão.
            Usuario user = new Usuario();
            Criptografia.CriarPasswordHash("123456", out byte[] hash, out byte[] salt);
            user.Id = 1;
            user.Username = "UsuarioAdmin";
            user.PasswordString = string.Empty;
            user.PasswordHash = hash;
            user.PasswordSalt = salt;
            user.Perfil = "Admin";
            user.Email = "seuEmail@gmail.com";
            user.Latitude = -23.5200241;
            user.Longitude = -46.596498;

            modelBuilder.Entity<Usuario>().HasData(user);
            //Fim da criação do usuário padrão.

            modelBuilder.Entity<Usuario>().Property(u => u.Perfil).HasDefaultValue("Jogador");

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings
                .Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        
    }
}