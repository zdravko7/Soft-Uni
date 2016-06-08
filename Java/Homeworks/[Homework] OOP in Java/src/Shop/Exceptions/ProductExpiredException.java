package Shop.Exceptions;

public class ProductExpiredException extends Exception {

    public ProductExpiredException() {
    }

    public ProductExpiredException(String message) {
        super(message);
    }

    public ProductExpiredException(String message, Throwable cause) {
        super(message, cause);
    }

    public ProductExpiredException(Throwable cause) {
        super(cause);
    }

    public ProductExpiredException(String message, Throwable cause, boolean enableSuppression, boolean writableStackTrace) {
        super(message, cause, enableSuppression, writableStackTrace);
    }
}
