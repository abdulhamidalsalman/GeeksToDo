const colors = require('tailwindcss/colors')


module.exports = {
    theme: {
        extend: {
            colors: {
                coolGray: colors.coolGray,
            },

            backgroundImage: theme => ({
                'sky': "url('/img/starry_sky.jpg')",
            }),
        }
    }
};