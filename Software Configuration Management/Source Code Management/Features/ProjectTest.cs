namespace Example {

    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ProjectTest {

        public Actionwords Actionwords;

        [SetUp]
        protected void SetUp() {
            Actionwords = new Actionwords();
        }

        [Test]
        public void UsuarioEstudianteDeseaTrabajarColaborativamente() {
        }

        [Test]
        public void UsuarioEstudianteDeseaTrabajarOnlineDeManeraColaborativamente() {
            // Given el usuario es un estudiante que tiene que trabajar con Scrum
            Actionwords.ElUsuarioEsUnEstudianteQueTieneQueTrabajarConScrum();
            // When se reúna con su equipo de trabajo
            Actionwords.SeReunaConSuEquipoDeTrabajo();
            // And necesite avanzar su proyecto entre todos los partícipes
            Actionwords.NecesiteAvanzarSuProyectoEntreTodosLosParticipes();
            // Then la aplicación permitirá compartir el proyecto
            Actionwords.LaAplicacionPermitiraCompartirElProyecto();
            // And trabajar de forma colaborativa en tiempo real
            Actionwords.TrabajarDeFormaColaborativaEnTiempoReal();
        }

        [Test]
        public void LiderDelEquipoScrumDeseaPlanificarLosSprintDeFormaRemota() {
            // Given el líder del equipo de Scrum quiere llevar a cabo la planificación del sprint de forma remota
            Actionwords.ElLiderDelEquipoDeScrumQuiereLlevarACaboLaPlanificacionDelSprintDeFormaRemota();
            // When esté en el apartado de “Sprints
            Actionwords.EsteEnElApartadoDeSprints();
            // Then podrá añadir y visualizar sprints
            Actionwords.PodraAnadirYVisualizarSprints();
            // And podrá ver las historias de usuario con las tasks que son necesarias para cumplirarlas
            Actionwords.PodraVerLasHistoriasDeUsuarioConLasTasksQueSonNecesariasParaCumplirarlas();
            // And podrá asignarles tiempo y responsable.
            Actionwords.PodraAsignarlesTiempoYResponsable();
        }

        [Test]
        public void UsuarioObtieneGuiasMedianteCuadrosDeTextosCuandoEsteRealizandoSuAvance() {
            // Given que el usuario se encuentra trabajando en la plataforma
            Actionwords.QueElUsuarioSeEncuentraTrabajandoEnLaPlataforma();
            // And es la primera vez que trabaja en la plataforma o con Scrum
            Actionwords.EsLaPrimeraVezQueTrabajaEnLaPlataformaOConScrum();
            // When se encuentre perdido y no encuentre una opción o función
            Actionwords.SeEncuentrePerdidoYNoEncuentreUnaOpcionOFuncion();
            // Then podrá solicitar guías en cuadro de textos pequeños para orientarse en la plataforma brindando ejemplos de las etapas
            Actionwords.PodraSolicitarGuiasEnCuadroDeTextosPequenosParaOrientarseEnLaPlataformaBrindandoEjemplosDeLasEtapas();
        }

        [Test]
        public void UsuarioDeseaRevisarLaListaDeVersionesParaVerLosAvancesDelProyecto() {
            // Given que el usuario es un miembro del equipo que desee ver los cambios nuevos
            Actionwords.QueElUsuarioEsUnMiembroDelEquipoQueDeseeVerLosCambiosNuevos();
            // When seleccione la opción “Estado del Proyecto ”
            Actionwords.SeleccioneLaOpcionEstadoDelProyecto();
            // Then obtendrá toda la lista de cambios que se realizaron recientemente
            Actionwords.ObtendraTodaLaListaDeCambiosQueSeRealizaronRecientemente();
            // And podrá revisar la información de cada cambio que se hizo junto con su autor.
            Actionwords.PodraRevisarLaInformacionDeCadaCambioQueSeHizoJuntoConSuAutor();
        }

        [Test]
        public void UsuarioAccedeALaPestanaDeGestionDeTareastasksDelProyecto() {
            // Given usuario miembro de equipo Scrum quiere gestionar o revisar las tareas
            Actionwords.UsuarioMiembroDeEquipoScrumQuiereGestionarORevisarLasTareas();
            // When escoja un proyecto en la sección de “Sprints”
            Actionwords.EscojaUnProyectoEnLaSeccionDeSprints();
            // And luego entre a la task que quiere revisar
            Actionwords.LuegoEntreALaTaskQueQuiereRevisar();
            // Then podrá editarla en tiempo real.
            Actionwords.PodraEditarlaEnTiempoReal();
        }

        [Test]
        public void UsuarioQuiereTrabajarConElProductBacklog() {
            // Given el usuario es un miembro del equipo Scrum
            Actionwords.ElUsuarioEsUnMiembroDelEquipoScrum();
            // When seleccione la opción “Product Backlog”
            Actionwords.SeleccioneLaOpcionProductBacklog();
            // Then podrá acceder a las historias de usuario creadas
            Actionwords.PodraAccederALasHistoriasDeUsuarioCreadas();
            // And podrá ordenarlas en orden de prioridad
            Actionwords.PodraOrdenarlasEnOrdenDePrioridad();
            // And añadir o editar las historias de usuario
            Actionwords.AnadirOEditarLasHistoriasDeUsuario();
        }

        [Test]
        public void UsuarioEstudianteDeseaLibreAccesoALasHerramientasYFuncionalidadesParaSusTrabajos() {
            // Given que el usuario estudiante necesita usar todas las funcionalidades para terminar los últimos entregables de su proyecto
            Actionwords.QueElUsuarioEstudianteNecesitaUsarTodasLasFuncionalidadesParaTerminarLosUltimosEntregablesDeSuProyecto();
            // When inicie sesión y seleccione un plan
            Actionwords.InicieSesionYSeleccioneUnPlan();
            // And seleccione la versión para estudiantes
            Actionwords.SeleccioneLaVersionParaEstudiantes();
            // Then podrá utilizar las funciones con libertad en su proyecto nuevo
            Actionwords.PodraUtilizarLasFuncionesConLibertadEnSuProyectoNuevo();
        }

        [Test]
        public void UsuarioDeseaSaberLaSituacionDelDesarrolloDelProductoMedianteNotificaciones() {
            // Given que el usuario miembro del equipo desea estar al pendiente de su avance
            Actionwords.QueElUsuarioMiembroDelEquipoDeseaEstarAlPendienteDeSuAvance();
            // When otros compañeros del equipo de trabajo avanzan el proyecto
            Actionwords.OtrosCompanerosDelEquipoDeTrabajoAvanzanElProyecto();
            // Then le llegará una notificación anunciando que un compañero está avanzando el proyecto
            Actionwords.LeLlegaraUnaNotificacionAnunciandoQueUnCompaneroEstaAvanzandoElProyecto();
        }

        [Test]
        public void UsuarioDeseaOrganizarASuEquipoEnLaPlataforma() {
            // Given que el usuario quiere añadir participantes para el proyecto en la plataforma
            Actionwords.QueElUsuarioQuiereAnadirParticipantesParaElProyectoEnLaPlataforma();
            // When presione en el botón “añadir”
            Actionwords.PresioneEnElBotonAnadir();
            // And el participante nuevo sea agregado en el equipo
            Actionwords.ElParticipanteNuevoSeaAgregadoEnElEquipo();
            // Then el usuario como rol “líder” podrá agregar a más participantes o eliminar a los existentes
            Actionwords.ElUsuarioComoRolLiderPodraAgregarAMasParticipantesOEliminarALosExistentes();
        }

        [Test]
        public void UsuarioDeseaUnaCrearUnaCuentaParaUnirseAlEquipoDeDesarrolloEnLaPlataforma() {
            // Given que el usuario miembro del equipo Scrum se le solicita unirse a la plataforma ScrumStudio
            Actionwords.QueElUsuarioMiembroDelEquipoScrumSeLeSolicitaUnirseALaPlataformaScrumStudio();
            // When el usuario reciba una invitación
            Actionwords.ElUsuarioRecibaUnaInvitacion();
            // And es su primera vez usando la plataforma
            Actionwords.EsSuPrimeraVezUsandoLaPlataforma();
            // Then se le solicitará crear una cuenta para utilizar la aplicación}
            Actionwords.SeLeSolicitaraCrearUnaCuentaParaUtilizarLaAplicacion();
        }

        [Test]
        public void UsuarioDeseaAmpliarLasFuncionesYCaracteristicasParaSuEmpresa() {
            // Given que se necesitan más equipos para desarrollar proyectos más grandes en la empresa del usuario
            Actionwords.QueSeNecesitanMasEquiposParaDesarrollarProyectosMasGrandesEnLaEmpresaDelUsuario();
            // When el usuario abra la ventana de “Planes”
            Actionwords.ElUsuarioAbraLaVentanaDePlanes();
            // And se le muestre los precios y los beneficios
            Actionwords.SeLeMuestreLosPreciosYLosBeneficios();
            // Then podrá comprar el plan que necesite para su empresa
            Actionwords.PodraComprarElPlanQueNecesiteParaSuEmpresa();
        }

        [Test]
        public void UsuarioSeLeDesignoHacerMasTrabajosConScrumEnEquiposDiferentes() {
            // Given que el usuario quiere añadir más equipos y su estado actual no se lo permite
            Actionwords.QueElUsuarioQuiereAnadirMasEquiposYSuEstadoActualNoSeLoPermite();
            // When abra la ventana de “Planes”
            Actionwords.AbraLaVentanaDePlanes();
            // And se suscriba al plan estudiantil
            Actionwords.SeSuscribaAlPlanEstudiantil();
            // Then podrá organizar más equipos de desarrollo en la plataforma
            Actionwords.PodraOrganizarMasEquiposDeDesarrolloEnLaPlataforma();
        }
    }
}