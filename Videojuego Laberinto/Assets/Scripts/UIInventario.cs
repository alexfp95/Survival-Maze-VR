using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIInventario : MonoBehaviour {

	private GameObject scriptsContenedor;
	private PlayerBD jugadorBD;
	public Inventario inventario;

	[SerializeField] public Imagenes imagenes;
	[System.Serializable] public class Imagenes {
		public Image[] slot, icono;
	}

	[SerializeField] public Iconos fotos;
	[System.Serializable] public class Iconos {
		public Sprite item1, item2, item3, hacha, piedra, juguete;
	}

	void Awake () {
		scriptsContenedor = GameObject.FindGameObjectWithTag ("Scripts");
		jugadorBD = scriptsContenedor.GetComponent<PlayerBD> ();
		inventario = scriptsContenedor.GetComponent<Inventario> ();
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < imagenes.icono.Length; i++) {
			if (jugadorBD.slots [i] == "Item 1") {
				imagenes.icono [i].sprite = fotos.item1;
				imagenes.icono [i].enabled = true;
			}
			if (jugadorBD.slots [i] == "Item 2") {
				imagenes.icono [i].sprite = fotos.item2;
				imagenes.icono [i].enabled = true;
			}
			if (jugadorBD.slots [i] == "Item 3") {
				imagenes.icono [i].sprite = fotos.item3;
				imagenes.icono [i].enabled = true;
			}
			if (jugadorBD.slots [i] == "Hacha") {
				imagenes.icono [i].sprite = fotos.hacha;
				imagenes.icono [i].enabled = true;
			}
			if (jugadorBD.slots [i] == "Piedra") {
				imagenes.icono [i].sprite = fotos.piedra;
				imagenes.icono [i].enabled = true;
			}
			if (jugadorBD.slots [i] == "Juguete") {
				imagenes.icono [i].sprite = fotos.juguete;
				imagenes.icono [i].enabled = true;
			}
			if (jugadorBD.slots [i] == "") {
				imagenes.icono [i].enabled = false;
			}
		}

		for (int j = 0; j < imagenes.slot.Length; j++) {
			if (j == inventario.slotActual) {
				imagenes.slot [j].color = new Color32 (87, 87, 87, 100);
			} else {
				imagenes.slot [j].color = new Color32 (185, 185, 185, 100);
			}
		}
	}
}
