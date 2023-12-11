using Microsoft.AspNetCore.Mvc;

namespace Cobranzas.Extensions
{
    public enum NotificationType
    {
        Success,
        Error,
        Info
    }

    public enum NotificationPosition
    {
        Top,
        TopStart,
        TopEnd,
        Center,
        CenterStart,
        CenterEnd,
        Bottom,
        BottomStart,
        BottomEnd
    }

    public class BaseController : Controller
    {
        string pos = "";
        /*
        Swal.fire({
            title: "The Internet?",
            text: "That thing is still around?",
            icon: "question"
        });*/
        public void BasicNotification(string msj, NotificationType type, string title = "")
        {
            TempData["notification"] = $"Swal.fire('{title}','{msj}', '{type.ToString().ToLower()}')";
        }
        /* Swal.fire({
            title: "Are you sure?",
            text: "You won't be able to revert this!",
            icon: "warning",
            showCancelButton: true,
            confirmButtonColor: "#3085d6",
            cancelButtonColor: "#d33",
            confirmButtonText: "Yes, delete it!"
            }).then((result) => {
            if (result.isConfirmed)
            {
                Swal.fire({
                title: "Deleted!",
                text: "Your file has been deleted.",
                icon: "success"
           });
        }
       });

     */
        public void ConfirmNotification(string msj, string confirmButtonText, string cancelButtonText, NotificationType type, string title = "", string confirmUrl = "")
        {
            TempData["notification"] = $"Swal.fire(" +
        $"'{title}'," +
        $"'{msj}', " +
        $"'{type.ToString().ToLower()}'," +
        $"{{" +
            $"showCancelButton: true," +
            $"confirmButtonColor: '#3085d6'," +
            $"cancelButtonColor: '#d33'," +
            $"confirmButtonText: '{confirmButtonText}'," +
            $"cancelButtonText: '{cancelButtonText}'" +
        $"}}).then((result) => {{" +
            $"if (result.isConfirmed) {{" +
                $"window.location.href = '{confirmUrl}';" +
            $"}}" +
        $"}})";
        }

        // el parametro de timer con valor 0 se deshabilita
        public void CustomNotification(string msj, NotificationType type, NotificationPosition position, string title = "", bool showConfirmButton = false, int timer = 2000, bool toast = true)
        {
            SetPosition(position.ToString());

            TempData["notification"] = "Swal.fire({customClass:{confirmButton:'btn btn-primary',cancelButton:'btn btn-danger'},position:'" + pos + "',type:'" + type.ToString().ToLower() +
                "',title:'" + title + "',text: '" + msj + "',showConfirmButton: " + showConfirmButton.ToString().ToLower() + ",confirmButtonColor: '#4F0DA2',toast: "
                + toast.ToString().ToLower() + ",timer: " + timer + "}); ";
        }

        public bool MostrarMensajeConfirmacion()
        {
            string mensaje = "¿Estás seguro?";
            // Llama al método CustomNotification para mostrar el mensaje de confirmación.
            CustomNotification(mensaje, NotificationType.Info, NotificationPosition.Center, "Confirmación", showConfirmButton: true);
            // Devuelve true si el usuario confirma o false si el usuario cancela.
            // La lógica de confirmación o cancelación dependerá de cómo procesas la interacción del usuario en tu aplicación.
            return true; // Cambia esto según la interacción del usuario.
        }
        #region Methods

        private void SetPosition(string position)
        {
            if (position == "Top") pos = "top";
            if (position == "TopStart") pos = "top-start";
            if (position == "TopEnd") pos = "top-end";
            if (position == "Center") pos = "center";
            if (position == "CenterStart") pos = "center-start";
            if (position == "CenterEnd") pos = "center-end";
            if (position == "Bottom") pos = "bottom";
            if (position == "BottomStart") pos = "bottom-start";
            if (position == "BottomEnd") pos = "bottom-end";
        }


        #endregion
    }
}
