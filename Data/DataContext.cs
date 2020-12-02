using App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Ocorrencia> Ocorrencias { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Turma> Turmas { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Ocorrencia>()
                 .HasOne(p => p.Aluno)
                 .WithMany(a => a.Ocorrencias)
                 .HasForeignKey(b => b.IdAluno);

            modelBuilder.Entity<Turma>()
                 .HasOne(p => p.Curso)
                 .WithMany(a => a.Turmas)
                 .HasForeignKey(b => b.IdCurso);

            modelBuilder.Entity<Aluno>()
                .HasOne(p => p.Turma)
                .WithMany(i => i.Alunos)
                .HasForeignKey(k => k.IdTurma);


        }
    }

}

