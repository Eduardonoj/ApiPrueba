namespace ApiPrueba;

public class Tarea
{
    public int TareaId {get;set;}
    public int CategoriaId {get;set;}
    public string Titulo {get;set;} = "";
    public string Descripcion {get;set;} = "";
    public Prioridad PrioridadTarea {get;set;}
    //public virtual Categoria Categoria{get;set;}
    public string Resumen {get;set;} = "";
}

public enum Prioridad{
    Baja,
    Media,
    Alta
}
