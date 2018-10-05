using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public enum NodeColor{Aggressive, Rational, Awkward}
public class ConversationNode : MonoBehaviour {
	public NodeColor nodeColor;
	private TextMeshPro text;
	private SpriteRenderer spr;
	public List<ConversationNode> parents = new List<ConversationNode>();
	public List<ConversationNode> children = new List<ConversationNode>();

	public Color aggroColor, rationalColor, awkwardColor;

	void Awake(){
		text = GetComponentInChildren<TextMeshPro>();
		spr = GetComponent<SpriteRenderer>();
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void UpdateImage(){
		if (nodeColor == NodeColor.Aggressive){
			spr.color = Color.red;
		}
		else if (nodeColor == NodeColor.Rational){
			spr.color = rationalColor;
		}
		else if (nodeColor == NodeColor.Awkward){
			spr.color = awkwardColor;
		}
	}
}
