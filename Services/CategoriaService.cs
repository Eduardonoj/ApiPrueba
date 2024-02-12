namespace ApiPrueba;

public class CategoriaService : ICategoriaService
{
    TareasContext context;
    public CategoriaService(TareasContext dbcontext){
        context = dbcontext;
    }

    public IEnumerable<Categoria> Get(){
        return context.Categorias;
    }

    public async Task Save(Categoria categoria){
        await context.SaveChangesAsync();
    }

    public async Task Update(int id, Categoria categoria){
        var categoriaActual = context.Categorias.Find(id);
        if(categoriaActual != null){
            categoriaActual.Nombre = categoria.Nombre;
            categoriaActual.Descripcion = categoria.Descripcion;
            categoria.Peso = categoria.Peso;

            await context.SaveChangesAsync();

        }
    }

 public async Task Delete(int id){
        var categoriaActual = context.Categorias.Find(id);
        if(categoriaActual != null){
         context.Remove(categoriaActual);

            await context.SaveChangesAsync();

        }
    }

}

public interface ICategoriaService{

Task Save(Categoria categoria);
Task Update(int id, Categoria categoria);
Task Delete(int id);
IEnumerable<Categoria> Get();

}