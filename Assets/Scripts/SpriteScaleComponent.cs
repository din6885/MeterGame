using UnityEngine;

[ExecuteInEditMode, RequireComponent(typeof(RectTransform))]
public class SpriteScaleComponent : MonoBehaviour
{
        // Attach this script onto a sprite renderer.
        // Stretches a sprite to follow corners of parent rect.
        // Make sure it's parented to a "dummy" rectTransform and stretch that instead of our tranform.
        //
        // IgorAherne March 2017
        // Marrt  July 2015
        // https://forum.unity3d.com/threads/overdraw-spriterenderer-in-ui.339912/#post-3009616
        // https://forum.unity3d.com/threads/overdraw-spriterenderer-in-ui.339912/#post-3009616
         

    [SerializeField] RectTransform _myRectTransform;
    [SerializeField] SpriteRenderer _mySpriteRenderer;

    void Reset()
    {
        Start();
    }


    void Start()
    {
        _mySpriteRenderer = GetComponent(typeof(SpriteRenderer)) as SpriteRenderer;
        _myRectTransform = transform as RectTransform;
    }



    void Update()
    {

#if UNITY_EDITOR
        //if we are in execute in edit mode, in editor, we might not have some references yet.
        //so establish them if needed:
        if (_mySpriteRenderer == null || _myRectTransform == null)
        {
            Start();
        }
#endif

        //keepScaleRelativeToParent();
    }



    public void keepScaleRelativeToParent()
    {

        float pxWidth = _myRectTransform.rect.width;            //width  of the scaled UI-Object in pixel
        float pxHeight = _myRectTransform.rect.height;        //height of the scaled UI-Object in pixel

        if (float.IsNaN(pxHeight) || float.IsNaN(pxWidth))
        {
            //unity hasn't not yet initialized (usually happens during start of the game)
            return;
        }

        _mySpriteRenderer.size = new Vector2(pxWidth, pxHeight);

    }

}

