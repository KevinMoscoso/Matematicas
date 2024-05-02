namespace testOperaciones;

public class UnitTest1
{
    [Theory]
    [InlineData(2, 3, 5)] //Prueba con datos fijos
    [InlineData(4, 3, 7)]
    [InlineData(8, 11, 19)]
    [InlineData(1, 1, 2)]
    [InlineData(212, 35, 247)]
    public void TestSuma(int a, int b, int resultadoEsperado)
    {
        ///AAA Arrange Act Assert
        ///Arrange: Preparar los datos de entrada
        int resultadoReal;
        ///Act: Invocar al metodo
        resultadoReal=operacionesBasicas.suma(a,b);
        ///Assert: verificar el resultado sea lo esperado
        Assert.Equal(resultadoEsperado, resultadoReal)
    }
}