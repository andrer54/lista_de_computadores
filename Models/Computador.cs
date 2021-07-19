namespace lista_de_computadores.Models {
    public class Computador{
        public Computador (){}
        public Computador (int id, string marca, string modelo, 
                      string placa_mae, string ram, string hdEMarca,
                      string velocidadeDoProcessador, string imagem )
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.placa_mae = placa_mae;
            this.ram = ram;
            this.hdEMarca = hdEMarca;
            this.velocidadeDoProcessador = velocidadeDoProcessador;
            this.imagem = imagem;

        }
            
        public int      id  {get; set;}
        public string marca  {get; set;}
        public string modelo  {get; set;}
        public string placa_mae  {get; set;}
        public string ram  {get; set;}
        public string hdEMarca  {get; set;}
        public string velocidadeDoProcessador  {get; set;}
        public string imagem  {get; set;}
    }
}