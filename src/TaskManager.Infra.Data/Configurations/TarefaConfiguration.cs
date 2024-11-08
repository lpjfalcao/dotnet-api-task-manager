﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Domain.Entities;

namespace TaskManager.Infra.Data.Configurations
{
    public class TarefaConfiguration : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.HasData(
                new Tarefa
                {
                    Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    Titulo = "Cadastrar Usuários no Sistema",
                    DataVencimento = DateTime.Now.AddDays(5),
                    Descricao = "Essa é uma tarefa para realizar o cadastro de usuários no sistema",
                    ProjetoId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                },
                new Tarefa
                {
                    Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                    Titulo = "Criar uma nova Sprint para o Projeto",
                    DataVencimento = DateTime.Now.AddDays(10),
                    Descricao = "Essa é uma tarefa para criar uma nova sprint para o projeto",
                    ProjetoId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                },
                new Tarefa
                {
                    Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                    Titulo = "Marcar reunião de retrospectiva com os membros do time",
                    DataVencimento = DateTime.Now.AddDays(15),
                    Descricao = "Essa é uma tarefa para marcar uma reunião com o time",
                    ProjetoId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                });
        }
    }
}
