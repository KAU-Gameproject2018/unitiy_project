using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler {

	//private Vector3 StartingPoint;
	public Transform parentToReturnTo = null;
	public enum Slot {Unused, Used};
	public Slot IsUsed = Slot.Unused;

	public void OnBeginDrag(PointerEventData eventData)
	{
		//StartingPoint.x = transform.position.x;
		//StartingPoint.y = transform.position.y;
		parentToReturnTo = this.transform.parent;
		this.transform.SetParent (this.transform.parent.parent);
		GetComponent<CanvasGroup> ().blocksRaycasts = false;
		//Debug.Log ("BeginDragparent : " + this.transform.parent);
	}

	public void OnDrag(PointerEventData eventData)
	{
		//Debug.Log ("OnDrag");
		this.transform.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		this.transform.SetParent(parentToReturnTo);
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		//Debug.Log ("EndDragparent : " + this.transform.parent);
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//Debug.Log ("Start X pos : " + StartingPoint.x);
		//Debug.Log ("Start Y pos : " + StartingPoint.y);
		//Debug.Log (transform.position.x);
	}


}
