(function ($) {
    var defaultOptions = {
        validClass: 'is-valid',
        errorClass: 'is-invalid',
        highlight: function (element, errorClass, validClass) {
            $(element).closest(".form-control")
                .removeClass(validClass)
                .addClass(errorClass);            
        },
        unhighlight: function (element, errorClass, validClass) {
            $(element).closest(".form-control")
                .removeClass(errorClass)
                .addClass(validClass);
        }
    };

    $.validator.setDefaults(defaultOptions);

    $.validator.unobtrusive.options = {
        errorClass: defaultOptions.errorClass,
        validClass: defaultOptions.validClass,
    };
})(jQuery);