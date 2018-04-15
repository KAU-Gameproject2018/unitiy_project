using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShootingZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

	public Draggable.Slot IsUsed = Draggable.Slot.Used;

	public void OnPointerEnter(PointerEventData eventData) {
		//Debug.Log ("OnPointerEnter");
	}
	public void OnPointerExit(PointerEventData eventData) {
		//Debug.Log ("OnPointerExit");
	}
	public void OnDrop(PointerEventData eventData) {
		Draggable d = eventData.pointerDrag.GetComponent<Draggable> ();
		if (d != null) {
			if (IsUsed != d.IsUsed) {
				d.parentToReturnTo = this.transform;
			}
		}
	}
}
