namespace exemplo;
class ClasseLampada
{
    public bool ligada;
    public double potencia;

    public void ligar(){
        ligada = true;
    }
    public void desligar(){
        ligada = false;
    }

    public bool estaLigada(){
        return ligada;
    }
}