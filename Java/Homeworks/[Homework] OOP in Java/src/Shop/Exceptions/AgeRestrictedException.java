package Shop.Exceptions;

public class AgeRestrictedException extends Exception {

    public AgeRestrictedException() {
    }

    public AgeRestrictedException(String message) {
        super(message);
    }

    public AgeRestrictedException(String message, Throwable cause) {
        super(message, cause);
    }

    public AgeRestrictedException(Throwable cause) {
        super(cause);
    }

    public AgeRestrictedException(String message, Throwable cause, boolean enableSuppression, boolean writableStackTrace) {
        super(message, cause, enableSuppression, writableStackTrace);
    }
}
