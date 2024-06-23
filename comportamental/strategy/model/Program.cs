
public interface Estrategia {
    void Executar();
}

public class EstrategiaConcreta1 : Estrategia {
    public void Executar(){
        Console.WriteLine("Executando estratégia 1");
    }
}

public class EstrategiaConcreta2 : Estrategia {
    public void Executar(){
        Console.WriteLine("Executando estratégia 2");
    }
}

public class Contexto {
    private Estrategia estrategia;

    public Contexto(Estrategia estrategia){
        this.estrategia = estrategia;
    }

    public void ExecutarEstrategia(){
        estrategia.Executar();
    }
}


class Program{
    static void Main(){
        Estrategia estrategia1 = new EstrategiaConcreta1();
        Estrategia estrategia2 = new EstrategiaConcreta2();

        Contexto contexto = new Contexto(estrategia1);
        contexto.ExecutarEstrategia();

        contexto = new Contexto(estrategia2);
        contexto.ExecutarEstrategia();
    }
}