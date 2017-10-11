using UnityEngine;

namespace Abstract
{
	public abstract class BulletController : MonoBehaviour
	{
		public abstract void Start();
		public abstract void Update();
		public abstract void OnCollisionEnter(Collision other);

		public float Speed;
	}
}