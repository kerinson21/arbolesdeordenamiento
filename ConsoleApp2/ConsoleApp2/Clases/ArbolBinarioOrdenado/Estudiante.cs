

/**
 *
 * @author Ruldin
 */
public class Estudiante : Comparador {

    public int numMat;
    public string nombre;

    public Estudiante()
    {

    }
    public Estudiante(int numMat, string nombre)
    {
        this.numMat = numMat;
        this.nombre = nombre;
    }
    public bool igualQue(object q)
    {
        //para la busqueda
        return true;
    }

    public bool mayorIgualQue(object q)
    {
        Estudiante p2 = (Estudiante)q;
        return numMat >= p2.numMat;
    }

    public bool mayorQue(object q)
    {
        Estudiante p2 = (Estudiante)q;
        return numMat > p2.numMat;
    }

    public bool menorIgualQue(object q)
    {
        Estudiante p2 = (Estudiante)q;
        return numMat <= p2.numMat;
    }

    public bool menorQue(object q)
    {
        Estudiante p2 = (Estudiante)q;
        return numMat < p2.numMat;
    }

}
