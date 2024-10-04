namespace ShowMilhao;

public class Universitarios : IAjuda
{
    public override void RealizaAjuda(Questao questao)
    {
        var porcentagem =100;
        for (int i =0; i <5; i++)
        {
            int nAleat =0;
            if (porcentagem>0)
            {
                nAleat = Random.Shared.Next (0,porcentagem);
                porcentagem-=nAleat;
            }
            switch (i)
            {
                case 0:
                btnResp01.Text+="="+ nAleat.ToString ()+"%";
                break;
                case 1:
                btnResp02.Text+="="+ nAleat.ToString ()+"%";
                break;
                case 2:
                btnResp03.Text+="="+ nAleat.ToString ()+"%";
                break;
                case 3:
                btnResp04.Text+="="+ nAleat.ToString ()+"%";
                break;
                case 4:
                btnResp05.Text+="="+ nAleat.ToString ()+"%";
                break;
            }
        }
    }
}