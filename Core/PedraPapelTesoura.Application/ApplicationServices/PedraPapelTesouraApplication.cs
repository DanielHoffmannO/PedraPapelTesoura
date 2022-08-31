using PedraPapelTesoura.Application.Interface;
using PedraPapelTesoura.Domain.Enum;
using PedraPapelTesoura.Domain.Modal;

namespace PedraPapelTesoura.Application.ApplicationServices;
public class PedraPapelTesouraApplication : IPedraPapelTesouraApplication
{
    public PedraPapelTesouraApplication()
    {
    }
    public int ContadorVc { get; set; }
    public int ContadorPc { get; set; }

    public int Contador(bool Vc)
    {
        return Vc? ContadorVc : ContadorPc;
    }

    private void Add(bool Vc)
    {
        if (Vc) ContadorVc++;
        if (!Vc) ContadorPc++;
    }

    public Result ProcessoPPT(PPT escolha)
    {
        Random random = new();
        var bot = (PPT)random.Next(0, 2);

        if (escolha == bot)
            return new(true, "Empate!");

        else if (escolha.Equals(PPT.Pedra) && bot.Equals(PPT.papel)
               ||escolha.Equals(PPT.papel) && bot.Equals(PPT.tesoura) 
               ||escolha.Equals(PPT.tesoura) && bot.Equals(PPT.Pedra))
        {
            Add(false);
            return new(true, "PC ganhou!");
        }
        Add(true);
        return new(true, "Ganhou!");
    }
}
