﻿using TaskManager.Domain.Entities;

namespace TaskManager.Domain.Interfaces.Services
{
    public interface ITarefaService
    {
        void ConfigurarPrioriedade(Tarefa tarefa);
        void ValidarPrioriedade(Tarefa tarefa);
        Task<Dictionary<Guid, double>> ObterMediaTarefasConcluidasPorUsuario(Guid usuarioId);
    }
}
