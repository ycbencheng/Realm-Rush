using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour {

  [SerializeField] List<Waypoint> path = new List<Waypoint>();

  // Start is called before the first frame update
  void Start()
  {
    PrintWaypointsName();
  }

  // Update is called once per frame
  void Update()
  {

  }

  void PrintWaypointsName() {
    foreach(Waypoint waypoint in path) {
      Debug.Log(waypoint.name);
    }
  }
}
