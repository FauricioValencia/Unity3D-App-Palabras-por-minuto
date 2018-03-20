using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class operacion : MonoBehaviour {

public InputField campoNPalabras, Segundos, numeroPaginas,numeroPalabras, tiempoMinutos,numeroPalabras_tiempo, metaDeVelocidad;
public Button calcular,consultar_VariasPaginas,averigualo_SaberMeta;
public Text resultado,resultadoVariasPaginas, resultadoFinal_tiempo;
public GameObject CanvasformaIndividual , menu , CanvasVariasPaginas, CanvasAveriguarTiempo, canvasCredito;

public void Individual () {
	
		CanvasformaIndividual.gameObject.SetActive (true);
		menu.gameObject.SetActive (false);
			
	}

public void FormaVariasPaginas () {
	
		CanvasVariasPaginas.gameObject.SetActive (true);
		menu.gameObject.SetActive (false);
	
	}

public void AveriguarTiempo() {
	
		CanvasAveriguarTiempo.gameObject.SetActive (true);
		menu.gameObject.SetActive (false);
	
	}
public void operar() {//metodo para calcular la velocidad de palabras por minuto, la opcion1
	
		string  campoPalabras=campoNPalabras.text;
		string campoSegundos = Segundos.text;
		float resultadoDou;
		resultadoDou = (float.Parse (campoPalabras) * 60) / float.Parse (campoSegundos);//operacion para saber la velocidad de lectura individual
		resultado.text =  Mathf.Round (resultadoDou) +" Palabras por minuto" ;
		resultado.gameObject.SetActive (true);
			
}

public void Consultar() {//metodo para calcular la velocidad de varias pagina, opcion 2
		//paginas x por cantidad de palabras por pagina / el tiempo en minutos

		string NumeroPaginas = numeroPaginas.text;
		string cantidadPalabras = numeroPalabras.text;
		string Tiempo = tiempoMinutos.text;

		float resultadoFloat = ((float.Parse (NumeroPaginas)) * (float.Parse (cantidadPalabras))) / float.Parse (Tiempo);
		resultadoVariasPaginas.text = "Tu velocidad de lectura promedio es de: "+Mathf.Round (resultadoFloat)+" palabras por minuto";
		resultadoVariasPaginas.gameObject.SetActive (true);
	
	}

public void averigualo() {//para saber cuanto tiempo debe tardar para conseguir la meta que desea
	// numero de palabras x 60 / palabras por minuto que se quiere llegar
		string numeroPalabras = numeroPalabras_tiempo.text;
		string velocidadMeta = metaDeVelocidad.text;

		float resultadoFloat = ((float.Parse (numeroPalabras)) * 60) / float.Parse (velocidadMeta);

		resultadoFinal_tiempo.text="El tiempo que tienes para llegar a la meta que deseas es de: "+ Mathf.Round (resultadoFloat)+" segundos";
		resultadoFinal_tiempo.gameObject.SetActive (true);
		Debug.Log ("holis");
		Debug.Log (resultadoFloat);

	}


	public void AlMenu () {


		if (CanvasformaIndividual.activeInHierarchy || CanvasAveriguarTiempo.activeInHierarchy || CanvasVariasPaginas) {
			menu.gameObject.SetActive (true);
			CanvasformaIndividual.gameObject.SetActive (false);
			CanvasAveriguarTiempo.gameObject.SetActive (false);
			CanvasVariasPaginas.gameObject.SetActive (false);
			canvasCredito.gameObject.SetActive (false);

			
		}

	}

	public void creditos() {
	
		menu.gameObject.SetActive (false);
		canvasCredito.SetActive (true);
	}


}
