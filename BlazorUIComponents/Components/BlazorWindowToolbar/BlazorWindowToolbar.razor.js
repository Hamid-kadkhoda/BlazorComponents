

function ListenToControl() {
    console.log("Listening To Control Key ....");
    document.addEventListener("keydown", (event) => {
        if (event.key.toUpperCase() == "CONTROL") {
            event.preventDefault();
            let el = document.querySelector(".blazor-window-toolbar");
            if (el.classList.contains("blazor-window-toolbar-dispose")) {
                el.classList.remove("blazor-window-toolbar-dispose");
            } else {
                el.classList.add("blazor-window-toolbar-dispose");
            }
        }
    })
}

ListenToControl();
 