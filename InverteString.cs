using System;
class InverteString {
    private string ultimo;

    public string inverte(string texto) {
        char[] charArray = texto.ToCharArray();
        Array.Reverse(charArray);
        this.ultimo = new string(charArray);
        return this.ultimo;
    }

    public string exibeUltimaInversao() {
        return this.ultimo;
    }
}