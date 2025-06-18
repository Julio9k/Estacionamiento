namespace Estacionamiento.entitis;

public class Espacio
{
    public int Id { get; set; }
    public string tipoDeEspacio { get; set; }
    public string estado { get; set; } = "Disponible";



    public List<Espacio> getListEspacios(string filtro)
    {
        var results = BaseDatosSimulada.Espacios.Where(e => e.tipoDeEspacio == filtro).ToList(); ;
        return results;
    }
}
