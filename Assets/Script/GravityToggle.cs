using UnityEngine;

public class GravityToggle : Interactive
{
    public new void Interact()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (!rb.useGravity && rb)
        {
            rb.useGravity = true;
        }
    }
}
