using PedraPapelTesoura.Domain.Enum;
using PedraPapelTesoura.Domain.Modal;

namespace PedraPapelTesoura.Application.Interface
{
    public interface IPedraPapelTesouraApplication
    {
        Result ProcessoPPT(PPT escolha);
        int Contador(bool Vc);
    }
}
