using UnityEngine;
using Vuplex.WebView;

class WebView : MonoBehaviour
{

   // CanvasWebViewPrefab _canvasWebViewPrefab1;
   // CanvasKeyboard _keyboard1;
    CanvasWebViewPrefab _canvasWebViewPrefab2;
    // CanvasKeyboard _keyboard2;
    CanvasWebViewPrefab _canvasWebViewPrefab3;
    CanvasWebViewPrefab _canvasWebViewPrefab4;
    CanvasWebViewPrefab _canvasWebViewPrefab5;
    CanvasWebViewPrefab _canvasWebViewPrefab6;
    CanvasWebViewPrefab _canvasWebViewPrefab7;

    async void Start()
    {

        // Use a desktop User-Agent to request the desktop versions of websites.
        // https://developer.vuplex.com/webview/Web#SetUserAgent
        Web.SetUserAgent(false);

        //var canvas1 = GameObject.Find("Canvas1");
        // Create a CanvasWebViewPrefab
        // https://developer.vuplex.com/webview/CanvasWebViewPrefab
        //_canvasWebViewPrefab1 = CanvasWebViewPrefab.Instantiate();
       // _canvasWebViewPrefab1.NativeOnScreenKeyboardEnabled = true;
       // _canvasWebViewPrefab1.transform.SetParent(canvas1.transform, false);

        var canvas2 = GameObject.Find("Canvas2");
        // Create a CanvasWebViewPrefab
        // https://developer.vuplex.com/webview/CanvasWebViewPrefab
        _canvasWebViewPrefab2 = CanvasWebViewPrefab.Instantiate();
        _canvasWebViewPrefab2.NativeOnScreenKeyboardEnabled = true;
        _canvasWebViewPrefab2.transform.SetParent(canvas2.transform, false);

        var canvas3 = GameObject.Find("Canvas3");
        // Create a CanvasWebViewPrefab
        // https://developer.vuplex.com/webview/CanvasWebViewPrefab
        _canvasWebViewPrefab3 = CanvasWebViewPrefab.Instantiate();
        _canvasWebViewPrefab3.NativeOnScreenKeyboardEnabled = true;
        _canvasWebViewPrefab3.transform.SetParent(canvas3.transform, false);

        var canvas4 = GameObject.Find("Canvas4");
        // Create a CanvasWebViewPrefab
        // https://developer.vuplex.com/webview/CanvasWebViewPrefab
        _canvasWebViewPrefab4 = CanvasWebViewPrefab.Instantiate();
        _canvasWebViewPrefab4.NativeOnScreenKeyboardEnabled = true;
        _canvasWebViewPrefab4.transform.SetParent(canvas4.transform, false);

        var canvas5 = GameObject.Find("Canvas5");
        // Create a CanvasWebViewPrefab
        // https://developer.vuplex.com/webview/CanvasWebViewPrefab
        _canvasWebViewPrefab5 = CanvasWebViewPrefab.Instantiate();
        _canvasWebViewPrefab5.NativeOnScreenKeyboardEnabled = true;
        _canvasWebViewPrefab5.transform.SetParent(canvas5.transform, false);

        var canvas6 = GameObject.Find("Canvas6");
        // Create a CanvasWebViewPrefab
        // https://developer.vuplex.com/webview/CanvasWebViewPrefab
        _canvasWebViewPrefab6 = CanvasWebViewPrefab.Instantiate();
        _canvasWebViewPrefab6.NativeOnScreenKeyboardEnabled = true;
        _canvasWebViewPrefab6.transform.SetParent(canvas6.transform, false);
  
        var canvas7 = GameObject.Find("Canvas7");
        // Create a CanvasWebViewPrefab
        // https://developer.vuplex.com/webview/CanvasWebViewPrefab
        _canvasWebViewPrefab7 = CanvasWebViewPrefab.Instantiate();
        _canvasWebViewPrefab7.NativeOnScreenKeyboardEnabled = true;
        _canvasWebViewPrefab7.transform.SetParent(canvas7.transform, false);

        // Create a CanvasKeyboard
        // https://developer.vuplex.com/webview/CanvasKeyboard
        //_keyboard1 = CanvasKeyboard.Instantiate();
        //_keyboard1.transform.SetParent(canvas1.transform, false);

        // Create a CanvasKeyboard
        // https://developer.vuplex.com/webview/CanvasKeyboard
        //_keyboard2 = CanvasKeyboard.Instantiate();
        //_keyboard2.transform.SetParent(canvas2.transform, false);

        _positionPrefabs();

        // Wait for the prefab to initialize because its WebView property is null until then.
        // https://developer.vuplex.com/webview/WebViewPrefab#WaitUntilInitialized
       // await _canvasWebViewPrefab1.WaitUntilInitialized();


        // Wait for the prefab to initialize because its WebView property is null until then.
        // https://developer.vuplex.com/webview/WebViewPrefab#WaitUntilInitialized
        await _canvasWebViewPrefab2.WaitUntilInitialized();

        // Wait for the prefab to initialize because its WebView property is null until then.
        // https://developer.vuplex.com/webview/WebViewPrefab#WaitUntilInitialized
        await _canvasWebViewPrefab3.WaitUntilInitialized();

        // Wait for the prefab to initialize because its WebView property is null until then.
        // https://developer.vuplex.com/webview/WebViewPrefab#WaitUntilInitialized
        await _canvasWebViewPrefab4.WaitUntilInitialized();

        // Wait for the prefab to initialize because its WebView property is null until then.
        // https://developer.vuplex.com/webview/WebViewPrefab#WaitUntilInitialized
        await _canvasWebViewPrefab5.WaitUntilInitialized();

        // Wait for the prefab to initialize because its WebView property is null until then.
        // https://developer.vuplex.com/webview/WebViewPrefab#WaitUntilInitialized
        await _canvasWebViewPrefab6.WaitUntilInitialized();

        // Wait for the prefab to initialize because its WebView property is null until then.
        // https://developer.vuplex.com/webview/WebViewPrefab#WaitUntilInitialized
        await _canvasWebViewPrefab7.WaitUntilInitialized();

        // After the prefab has initialized, you can use the IWebView APIs via its WebView property.
        // https://developer.vuplex.com/webview/IWebView
       // _canvasWebViewPrefab1.WebView.LoadUrl("https://freepacman.org/");

        // After the prefab has initialized, you can use the IWebView APIs via its WebView property.
        // https://developer.vuplex.com/webview/IWebView
        _canvasWebViewPrefab2.WebView.LoadUrl("https://freeasteroids.org/");

        // After the prefab has initialized, you can use the IWebView APIs via its WebView property.
        // https://developer.vuplex.com/webview/IWebView
        _canvasWebViewPrefab3.WebView.LoadUrl("https://happyhopper.org/");


        // After the prefab has initialized, you can use the IWebView APIs via its WebView property.
        // https://developer.vuplex.com/webview/IWebView
        _canvasWebViewPrefab4.WebView.LoadUrl("https://freeflappybird.org/");


        // After the prefab has initialized, you can use the IWebView APIs via its WebView property.
        // https://developer.vuplex.com/webview/IWebView
        _canvasWebViewPrefab5.WebView.LoadUrl("https://freekong.org/");

        // After the prefab has initialized, you can use the IWebView APIs via its WebView property.
        // https://developer.vuplex.com/webview/IWebView
        _canvasWebViewPrefab6.WebView.LoadUrl("https://freepong.org/");

        // After the prefab has initialized, you can use the IWebView APIs via its WebView property.
        // https://developer.vuplex.com/webview/IWebView
        _canvasWebViewPrefab7.WebView.LoadUrl("https://freepacman.org/");
    }

    /// <summary>
    /// Note that it's easier to position the CanvasWebViewPrefab and CanvasKeyboard
    /// simply by dragging CanvasWebViewPrefab.prefab and CanvasKeyboard.prefab
    /// into the Canvas and adjusting their RectTransforms in the editor, but it's done here via script
    /// to make it easy to distribute this project without 3D WebView's assets.
    /// </summary>
    void _positionPrefabs()
    {

       // var rectTransform1 = _canvasWebViewPrefab1.transform as RectTransform;
       // rectTransform1.anchoredPosition3D = Vector3.zero;
       // rectTransform1.offsetMin = new Vector2(0, 1);
       // rectTransform1.offsetMax = Vector2.one;
       // rectTransform1.pivot = new Vector2(0.5f, 1);
       // rectTransform1.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 520);
       // _canvasWebViewPrefab1.transform.localScale = Vector3.one;

        var rectTransform2 = _canvasWebViewPrefab2.transform as RectTransform;
        rectTransform2.anchoredPosition3D = Vector3.zero;
        rectTransform2.offsetMin = new Vector2(0, 1);
        rectTransform2.offsetMax = Vector2.one;
        rectTransform2.pivot = new Vector2(0.5f, 1);
        rectTransform2.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 520);
        _canvasWebViewPrefab2.transform.localScale = Vector3.one;

        var rectTransform3 = _canvasWebViewPrefab3.transform as RectTransform;
        rectTransform3.anchoredPosition3D = Vector3.zero;
        rectTransform3.offsetMin = new Vector2(0, 1);
        rectTransform3.offsetMax = Vector2.one;
        rectTransform3.pivot = new Vector2(0.5f, 1);
        rectTransform3.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 520);
        _canvasWebViewPrefab3.transform.localScale = Vector3.one;

        var rectTransform4 = _canvasWebViewPrefab4.transform as RectTransform;
        rectTransform4.anchoredPosition3D = Vector3.zero;
        rectTransform4.offsetMin = new Vector2(0, 1);
        rectTransform4.offsetMax = Vector2.one;
        rectTransform4.pivot = new Vector2(0.5f, 1);
        rectTransform4.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 520);
        _canvasWebViewPrefab4.transform.localScale = Vector3.one;

        var rectTransform5 = _canvasWebViewPrefab5.transform as RectTransform;
        rectTransform5.anchoredPosition3D = Vector3.zero;
        rectTransform5.offsetMin = new Vector2(0, 1);
        rectTransform5.offsetMax = Vector2.one;
        rectTransform5.pivot = new Vector2(0.5f, 1);
        rectTransform5.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 520);
        _canvasWebViewPrefab5.transform.localScale = Vector3.one;


        var rectTransform6 = _canvasWebViewPrefab6.transform as RectTransform;
        rectTransform6.anchoredPosition3D = Vector3.zero;
        rectTransform6.offsetMin = new Vector2(0, 1);
        rectTransform6.offsetMax = Vector2.one;
        rectTransform6.pivot = new Vector2(0.5f, 1);
        rectTransform6.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 520);
        _canvasWebViewPrefab6.transform.localScale = Vector3.one;

        var rectTransform7 = _canvasWebViewPrefab6.transform as RectTransform;
        rectTransform7.anchoredPosition3D = Vector3.zero;
        rectTransform7.offsetMin = new Vector2(0, 1);
        rectTransform7.offsetMax = Vector2.one;
        rectTransform7.pivot = new Vector2(0.5f, 1);
        rectTransform7.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 520);
        _canvasWebViewPrefab7.transform.localScale = Vector3.one;


        // var keyboardTransform1 = _keyboard1.transform as RectTransform;
        // keyboardTransform1.anchoredPosition3D = Vector3.zero;
        // keyboardTransform1.offsetMin = new Vector2(0.5f, 0);
        // keyboardTransform1.offsetMax = new Vector2(0.5f, 0);
        // keyboardTransform1.pivot = new Vector2(0.5f, 0);
        // keyboardTransform1.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 650);
        // keyboardTransform1.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 162);

        //  var keyboardTransform2 = _keyboard2.transform as RectTransform;
        //  keyboardTransform2.anchoredPosition3D = Vector3.zero;
        //  keyboardTransform2.offsetMin = new Vector2(0.5f, 0);
        //  keyboardTransform2.offsetMax = new Vector2(0.5f, 0);
        //  keyboardTransform2.pivot = new Vector2(0.5f, 0);
        //  keyboardTransform2.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 650);
        //  keyboardTransform2.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 162);
    }
}
