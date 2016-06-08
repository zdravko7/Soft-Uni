package Shop.Exceptions;

public class NoQuantityException extends Exception {

    public NoQuantityException() {
    }

    public NoQuantityException(String message) {
        super(message);
    }

    public NoQuantityException(String message, Throwable cause) {
        super(message, cause);
    }

    public NoQuantityException(Throwable cause) {
        super(cause);
    }

    public NoQuantityException(String message, Throwable cause, boolean enableSuppression, boolean writableStackTrace) {
        super(message, cause, enableSuppression, writableStackTrace);
    }
}
