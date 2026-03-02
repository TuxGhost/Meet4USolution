const path = require('path')
const CopyPlugin = require('copy-webpack-plugin')

module.exports = {
    entry: './js/app.js',
    output: {
        filename: 'bootstrap-dit.js',
        path: path.resolve(__dirname, 'wwwroot/dist')
    },
    module: {
        rules: [
            {
                test: /\.css$/,
                use: ['style-loader', {
                    loader: 'css-loader',
                    options: {
                        sourceMap: true
                    }
                }]
            }
        ]
    },
    plugins: [
        new CopyPlugin({
            patterns: [                
                { from: 'jquery/dist/jquery.min.js', to: 'vendor/jquery', context: 'node_modules' },
                { from: 'bootstrap/dist/js/bootstrap.bundle.min.js', to: 'vendor/bootstrap', context: 'node_modules' },
                { from: 'bootstrap/dist/css/bootstrap.min.css', to: 'vendor/bootstrap', context: 'node_modules' }
            ]
        })           
    ]    
}
