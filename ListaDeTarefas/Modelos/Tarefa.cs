namespace ListaDeTarefas.Modelos;

public record class Tarefa(int Id, string Titulo, DateOnly Prazo, bool Concluido);