﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskManager.Infra.Data.Contextos;

#nullable disable

namespace TaskManager.Infra.Data.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TaskManager.Domain.Entities.HistoricoAlteracao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("HistoricoAlteracaoId");

                    b.Property<string>("Antes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CampoAlterado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Depois")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TarefaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TarefaId");

                    b.ToTable("HistoricoAlteracoes");
                });

            modelBuilder.Entity("TaskManager.Domain.Entities.Projeto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ProjetoId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projetos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Nome = "Projeto Z"
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            Nome = "Projeto X"
                        });
                });

            modelBuilder.Entity("TaskManager.Domain.Entities.Tarefa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TarefaId");

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Prioridade")
                        .HasColumnType("int");

                    b.Property<Guid>("ProjetoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProjetoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Tarefas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                            DataVencimento = new DateTime(2024, 11, 16, 10, 23, 1, 652, DateTimeKind.Local).AddTicks(4734),
                            Descricao = "Essa é uma tarefa para realizar o cadastro de usuários no sistema",
                            Prioridade = 2,
                            ProjetoId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Status = 1,
                            Titulo = "Cadastrar Usuários no Sistema",
                            UsuarioId = new Guid("a69c1158-3c7e-4441-a3da-d060c2b5604c")
                        },
                        new
                        {
                            Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                            DataVencimento = new DateTime(2024, 11, 21, 10, 23, 1, 652, DateTimeKind.Local).AddTicks(4751),
                            Descricao = "Essa é uma tarefa para criar uma nova sprint para o projeto",
                            Prioridade = 1,
                            ProjetoId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Status = 3,
                            Titulo = "Criar uma nova Sprint para o Projeto",
                            UsuarioId = new Guid("a69c1158-3c7e-4441-a3da-d060c2b5604c")
                        },
                        new
                        {
                            Id = new Guid("88696b49-5c8c-4927-a0a5-cc756e0df8b9"),
                            DataVencimento = new DateTime(2024, 11, 21, 10, 23, 1, 652, DateTimeKind.Local).AddTicks(4754),
                            Descricao = "Essa é uma tarefa para criar uma nova sprint para o projeto",
                            Prioridade = 1,
                            ProjetoId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Status = 3,
                            Titulo = "Criar uma nova Sprint para o Projeto",
                            UsuarioId = new Guid("a69c1158-3c7e-4441-a3da-d060c2b5604c")
                        },
                        new
                        {
                            Id = new Guid("88f32217-dfdf-4929-bf2d-0714d3178afa"),
                            DataVencimento = new DateTime(2024, 11, 21, 10, 23, 1, 652, DateTimeKind.Local).AddTicks(4756),
                            Descricao = "Essa é uma tarefa para cadastrar usuários no banco de dados",
                            Prioridade = 1,
                            ProjetoId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Status = 3,
                            Titulo = "Cadastrar Usuários no banco de dados",
                            UsuarioId = new Guid("a69c1158-3c7e-4441-a3da-d060c2b5604c")
                        },
                        new
                        {
                            Id = new Guid("a39740f1-2ad5-4a15-95b1-52bcb0530728"),
                            DataVencimento = new DateTime(2024, 11, 26, 10, 23, 1, 652, DateTimeKind.Local).AddTicks(4759),
                            Descricao = "Essa é uma tarefa para migrar o banco de dados",
                            Prioridade = 3,
                            ProjetoId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            Status = 2,
                            Titulo = "Migar o banco de dados SQL Server para o DynamoDB",
                            UsuarioId = new Guid("0f58ef89-c87e-4c09-a9ad-4cbc2f764aec")
                        },
                        new
                        {
                            Id = new Guid("c75e6e5b-d81c-4cbd-b197-650abccc352b"),
                            DataVencimento = new DateTime(2024, 11, 26, 10, 23, 1, 652, DateTimeKind.Local).AddTicks(4761),
                            Descricao = "Essa é uma tarefa para migrar o banco de dados",
                            Prioridade = 3,
                            ProjetoId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            Status = 2,
                            Titulo = "Migar o banco de dados SQL Server para o DynamoDB",
                            UsuarioId = new Guid("0f58ef89-c87e-4c09-a9ad-4cbc2f764aec")
                        });
                });

            modelBuilder.Entity("TaskManager.Domain.Entities.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UsuarioId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0f58ef89-c87e-4c09-a9ad-4cbc2f764aec"),
                            Nome = "Jimmy Page"
                        },
                        new
                        {
                            Id = new Guid("a69c1158-3c7e-4441-a3da-d060c2b5604c"),
                            Nome = "Jimmy Hendrix"
                        });
                });

            modelBuilder.Entity("TaskManager.Domain.Entities.HistoricoAlteracao", b =>
                {
                    b.HasOne("TaskManager.Domain.Entities.Tarefa", "Tarefa")
                        .WithMany("HistoricoAlteracoes")
                        .HasForeignKey("TarefaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tarefa");
                });

            modelBuilder.Entity("TaskManager.Domain.Entities.Tarefa", b =>
                {
                    b.HasOne("TaskManager.Domain.Entities.Projeto", "Projeto")
                        .WithMany("Tarefa")
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManager.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Tarefas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Projeto");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("TaskManager.Domain.Entities.Projeto", b =>
                {
                    b.Navigation("Tarefa");
                });

            modelBuilder.Entity("TaskManager.Domain.Entities.Tarefa", b =>
                {
                    b.Navigation("HistoricoAlteracoes");
                });

            modelBuilder.Entity("TaskManager.Domain.Entities.Usuario", b =>
                {
                    b.Navigation("Tarefas");
                });
#pragma warning restore 612, 618
        }
    }
}
