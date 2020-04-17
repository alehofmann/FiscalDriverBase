using System.Collections.Generic;
using System.Runtime.InteropServices;

using DCS.FiscalDriverBase.Dto;

namespace DCS.FiscalDriverBase
{
    [ComVisible(true)]
    [Guid("85CED1BB-A0AD-4A5D-9975-4A634480821E")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IFiscalDriverBase
    {
        bool Create(string sacoaShare,
                    string dummyParam = ""
                   );
        //Debe ser ejecutado inmediatamente despues del "New". Devuelve TRUE o FALSE si pudo o no ser creado/inicializado con éxito.
        //Deberan chequearse como existencia y consistencia de parámetros de configuración, conectividad, etc.
        //sacoaShare va vacío
        //En dummyParam enviaremos un "ConnectionString" con los parámetros de configuración que sean necesario para que la interfase opere
        //Ej: "TERMINAL:=12;RUC="33-22122122-22";NRO_COMERCIO:=3343;ALICUOTA:=21"

        bool DriverPrintsFromTransactionObject();
        //Debe devolver siempre TRUE

        int LastError();
        //Devolver siempre 0

        string LastErrorString();
        //Cuando alguna de las bool devuelve FALSE, acá es donde figura la razón

        bool NeedsZClose();
        //Esta rutina devuelve TRUE si el driver está listo para operar y si el host program puede comenzar o proseguir con la transacción.
        //Caso contrario deberá especificar la razón en LastErrorString
        //Ejemplo de razones son: "Imposible conectarse con el servidor ...", "Debe hacerse un cierre Z", "Debe renovar el RUC", o directamente
        //el mensaje devuelto por el Web Service (de existir uno)

        [ComVisible(false)]
        bool OpenTransaction(ref IList<KeyValuePair<string, string>> transactionCommandsToApply);
        //Devuelve TRUE o FALSE dependiendo de si el Host Program debe proseguir con la transacción. El motivo para un FALSE podría ser un error, pero mas habitualmente puede ser debido 
        //a que el cliente dio "cancel" a un form con pedido de datos adicionales para la facturación. Los datos adicionales pueden ser retenidos por el driver hasta el momento
        //del "PrintTransaction" o devueltos en "transactionCommandsToApply" para ser utilizados por el HostProgram. Esto va en la especificación de cada implementación de una interfase fiscal.

        bool OpenTransaction(ref VBA.Collection transactionCommandsToApply);
        //Version compatible VB6/ActiveX

        bool PerformXClose();
        //Cierre X

        bool PerformZClose(ref int zCloseNumber,
                           bool dummyParam = true
                          );
        //Cierre Z

        [ComVisible(false)]
        bool PrintNonFiscalDoc(System.Collections.Generic.IList<string> textLines,
                               ref int nonFiscalDocNumber,
                               bool dummyParam1 = true,
                               bool dummyParam2 = true
                              );

        bool PrintNonFiscalDoc(VBA.Collection textLines,
                               ref int nonFiscalDocNumber,
                               bool dummyParam1 = true,
                               bool dummyParam2 = true
                              );
        //En el caso de que la interfase fiscal incluya una impresora, esta rutina es utilizada por el Host Program para imprimir tickets no-fiscales.

            /*  Braian 190804 Se elimina referencia a POSUtils  */
        //bool PrintTransaction(clsPOSXaction posTransaction,
        //                      ref int invoiceNumber,
        //                      bool dummyParam = true
        //                     );

        //Version para uso exclusivo del POS. 
        //Debe instanciar un TransactionDto y luego "llenarlo a partir de clsPOSXaction utilizando TransactionDto.FillDtoFromPosTransaction
        //Luego debe llamar al otro overload de PrintTransaction que recibe el TransactionDto como parametro.

        [ComVisible(false)]
        bool PrintTransaction(TransactionDto transaction,
                              ref int invoiceNumber,
                              bool dummyParam = true
                             );
        //Acá se hace el trabajo "real": Avisa al ente fiscal o Gateway de facturación de ser necesario, imprime el ticket de estar especificado, etc.
        //Devuelve TRUE o FALSE según el éxito de la operación (el error de existir en LastErrorString), y el "invoiceNumber" generado por el facturador o la impresora fiscal.

        int ProcessId();
        //Acá debe devolver el ProcessId del driver
    }
}