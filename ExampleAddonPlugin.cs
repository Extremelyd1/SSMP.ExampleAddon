using BepInEx;
using SSMP.Api.Client;
using SSMP.Api.Server;

namespace SSMP.ExampleAddon;

/// <summary>
/// The plugin class for the SSMP ExampleAddon.
/// You should be familiar with this already, since this is the basis for a normal mod.
/// </summary>
[BepInAutoPlugin(id: "ssmp.example-addon")]
[BepInDependency("ssmp")]
public partial class ExampleAddonPlugin : BaseUnityPlugin {
    private void Awake() {
        // Put your initialization logic here
        Logger.LogInfo($"Plugin {Name} ({Id}) has loaded!");

        // Register both the client and server addon during the Awake of this MonoBehaviour
        // Doing it anywhere else might result in an exception, because addon loading by SSMP might have already
        // occurred.
        ClientAddon.RegisterAddon(new ExampleClientAddon());
        ServerAddon.RegisterAddon(new ExampleServerAddon());
    }
}