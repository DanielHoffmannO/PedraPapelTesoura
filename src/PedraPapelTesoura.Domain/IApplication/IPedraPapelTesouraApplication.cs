using PedraPapelTesoura.Domain.Enum;
using PedraPapelTesoura.Domain.Modal;

namespace PedraPapelTesoura.Domain.IApplication
{
    public interface IPedraPapelTesouraApplication
    {
        Result ProcessoPPT(PPT escolha);
        int Contador(bool Vc);
    }
}
